public class TransactionService
{
    private readonly TransactionRepository repository;
    private readonly SessionRepository sessionRepository;

    public TransactionService(SessionRepository _sessionRepository,TransactionRepository _repository)
    {
        this.repository = _repository;
        this.sessionRepository = _sessionRepository;
    }

    public Transaction Create(Transaction transactionRequest)
    {
        Session validSession = new();
        foreach (Session session in sessionRepository.DB)
        {
            if(transactionRequest.id_session == session.id)
            {
                validSession = session;
            }
        }
        // lanjutin ini session dan transaction

        return new();
    }
}