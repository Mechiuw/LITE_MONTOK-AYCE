public class SessionService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly SessionRepository repository;
    private readonly PackageMenuRepository packageMenuRepository;
    private readonly PenaltyRepository penaltyRepository;
    private readonly TableRepository tableRepository;
    private readonly TransactionService trxService;
    public SessionService(
    TransactionService _trxService,
    SessionRepository _repository,
    PackageMenuRepository _packageMenuRepository,
    PenaltyRepository _penaltyRepository,
    TableRepository _tableRepository)
{
    this.trxService = _trxService;
    this.repository = _repository;
    this.packageMenuRepository = _packageMenuRepository;
    this.penaltyRepository = _penaltyRepository;
    this.tableRepository = _tableRepository;
}
    // ==================================

    public Session Create(Session sessionRequest)
    {
        string generateId = Guid.NewGuid().ToString();
        // VALIDASI PACKAGEMENU PADA SESSION
        var packageIds = new HashSet<string>(sessionRequest.id_package); // hashset agar proses lebih cepat
        List<PackageMenu> validPackages = [.. packageMenuRepository.DB.Where(c => packageIds.Contains(c.id))]; // cari package yang ada dan valid
        if(validPackages.Count != packageIds.Count)
        {
            throw new Exception("Invalid Package Detected");
        }
        
        
        // VALIDASI PENALTY PADA SESSION
        var penaltyIds = new HashSet<string>(sessionRequest.id_penalties); // tampung id penalty masing2
        List<Penalty> validPenalty = [.. penaltyRepository.DB.Where(x => penaltyIds.Contains(x.id))]; // cari penalty yang ada dan valid
        if(validPenalty.Count != penaltyIds.Count)
        {
            throw new Exception("Invalid Penalty Detected");
        }

        // VALIDASI TABLE PADA SESSION
        var validTable = tableRepository.DB.FirstOrDefault(x => x.table_num == sessionRequest.id_current_table) 
        ?? throw new Exception("Valid Table Result in session is null or not found");
        // pastikan di dispatch nanti akan manggil tableservice buat book table

        // CREATE SESSION NYA dengan value yang udah di validasi
        Session newValidSession = new()
        {
            id = generateId,
            total_person = sessionRequest.total_person,
            id_current_table = validTable.table_num,
            id_package = [.. validPackages.Select(x => x.id)],
            start_time = DateTime.UtcNow,
            end_time = null, // sengaja null karena akan di assign nanti lewat EndSession();
            id_penalties = [.. validPenalty.Select(x => x.id)],
            open_status = true
        };

        repository.DB.Add(newValidSession);
        return newValidSession;
    }
    public Session FindSession(string id)
    {
        return repository.DB.First(session => session.id == id) 
        ?? throw new Exception($"Not found any Session with id :{id}");
    }
    public List<Session> FindActiveSession()
    {
        return [.. repository.DB.Where(session => session.open_status)];
    }
    public Session EndSession(string id)
    {
        
        // FIND INDEX
        int targetIndex = repository.DB.FindIndex(session => session.id == id);
        if(targetIndex == -1)
        {
            throw new Exception();
        }

        // GUARD
        if (!repository.DB[targetIndex].open_status)
        {
            throw new Exception("Session already closed");
        }

        Session targetSession = repository.DB[targetIndex]; // buat obj session baru

        targetSession.open_status = false; // set open_status jadi false
        targetSession.end_time = DateTime.Now; // set end time date sekarang
        repository.DB[targetIndex] = targetSession; // tindih data
        
        List<PackageMenu> packageMenus = [.. packageMenuRepository.DB.Where(x => targetSession.id_package.Contains(x.id))]; // cari semua paket menu yang diambil
        List<Penalty> penalties = [.. penaltyRepository.DB.Where(x => targetSession.id_penalties.Contains(x.id))]; // cari semua penalty yang ada

        double totalPackage = TrxCalculator.CalculatePackage(packageMenus); // hitung total dari package 
        double totalPenalty = TrxCalculator.CalculatePenalty(penalties); // hitung total dari penalty

        double totalTrx = TrxCalculator.CalculatePayment(targetSession.total_person, totalPenalty, totalPackage); // hitung total semua
        trxService.CreatePermanent(targetSession.id,totalTrx); // panggil dan buat transaction langsung, karena data semuanya terpusat di session

        return targetSession; // kembalikan session
    }

}