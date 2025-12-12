public class PenaltyService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly PenaltyRepository repository;
    public PenaltyService(PenaltyRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================
}