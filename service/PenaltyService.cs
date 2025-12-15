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
        Penalty cash = new();
        cash.penalty_type = penaltyRequest.penalty_type;
        cash.pay_penalty = penaltyRequest.pay_penalty;

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
        Penalty findPenalty = FindAnyPenalty(penaltyRequest.id);
        int targetIndex = repository.DB.FindIndex(x => x.id == findPenalty.id);
        repository.DB[targetIndex] = penaltyRequest;

        Penalty penaltyResponse = findPenalty;

        return penaltyResponse;
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