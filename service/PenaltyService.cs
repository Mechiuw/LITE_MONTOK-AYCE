public class PenaltyService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly PenaltyRepository repository;
    public PenaltyService(PenaltyRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================

    public Penalty CreatePenalty(Penalty penaltyRequest){return null;}
    public Penalty FindAnyPenalty(string id){return repository.DB.First(x => x.id == id);}
    public List<Penalty> FindAllPenalty(){return repository.DB;}
    public Penalty UpdatePenalty(Penalty penaltyRequest){return null;}
    public void DeletePenalty(){}
}