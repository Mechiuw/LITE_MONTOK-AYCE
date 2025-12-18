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
        int targetIndex = repository.DB.FindIndex(x => x.id == penaltyRequest.id); // cari index yang dituju

        if(targetIndex == -1) // validasi jika index gaada
        {
            throw new Exception("PENALTY NOT FOUND");
        }

        repository.DB[targetIndex] = penaltyRequest; // ganti / tindih value dengan index yang dimaksud dengan value baru
        return penaltyRequest; // kembalikan hasil nya 

    }
    public void DeletePenalty(string id)
    {
        int targetIndex = repository.DB.FindIndex(x => x.id == id); // cari index yang dituju

        if(targetIndex == -1) // validasi jika index gaada
        {
            throw new Exception("PENALTY NOT FOUND");
        }

        repository.DB.RemoveAt(targetIndex);
    }

}