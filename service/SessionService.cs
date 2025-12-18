public class SessionService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly SessionRepository repository;
    private readonly PackageMenuRepository packageMenuRepository;
    private readonly PenaltyRepository penaltyRepository;
    private readonly TableRepository tableRepository;
    public SessionService(
    SessionRepository _repository,
    PackageMenuRepository _packageMenuRepository,
    PenaltyRepository _penaltyRepository,
    TableRepository _tableRepository)
{
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
        var penaltyIds = new HashSet<string>(sessionRequest.penalties); // tampung id penalty masing2
        List<Penalty> validPenalty = [.. penaltyRepository.DB.Where(x => sessionRequest.penalties.Contains(x.id))]; // cari penalty yang ada dan valid
        if(validPenalty.Count != penaltyIds.Count)
        {
            throw new Exception("Invalid Penalty Detected");
        }

        // VALIDASI TABLE PADA SESSION
        var validTable = tableRepository.DB.FirstOrDefault(x => x.table_num == sessionRequest.id_current_table);
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
            penalties = [.. validPenalty.Select(x => x.id)],
            open_status = true
        };

        repository.DB.Add(newValidSession);
        return newValidSession;
    }
    public Session FindSession(string id){return null;}
    public List<Session> FindActiveSession()
    {
        return repository.DB;
    }
    public Session UpdateSession(Session sessionRequest){return null;}
    public void DeleteSession(string id){}
}