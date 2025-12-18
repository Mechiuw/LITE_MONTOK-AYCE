public class PenaltyService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly PenaltyRepository repository;
    public PenaltyService(PenaltyRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================

    public Penalty CreatePenalty(Penalty penaltyRequest)
    {
        Penalty cash = new()
        {
            penalty_type = penaltyRequest.penalty_type,
            pay_penalty = penaltyRequest.pay_penalty
        };

        repository.DB.Add(cash);
        return cash;
    }
    public Penalty FindAnyPenalty(string id)
    {
        foreach (Penalty penalty in repository.DB)
        {
            if (penalty.id == id)
            {
                return penalty;
            }
        }
        return null;
    }
    public List<Penalty> FindAllPenalty(){return repository.DB;}
    public Penalty UpdatePenalty(Penalty penaltyRequest)
    {
        _ = FindAnyPenalty(penaltyRequest.id); // validasi, akan otomatis discard value karena hanya butuh validasi

        int targetIndex = repository.DB.FindIndex(x => x.id == penaltyRequest.id); // cari index yang dituju
        repository.DB[targetIndex] = penaltyRequest; // ganti / tindih value dengan index yang dimaksud dengan value baru
        return penaltyRequest; // kembalikan hasil nya 

    }
    public void DeletePenalty(string id)
    {
        foreach (Penalty findPenalty in repository.DB)
        {
            if(findPenalty.id == id)
            {
                repository.DB.Remove(findPenalty);
            }
        }
    }
}