public class TransactionService
{
    private readonly TransactionRepository repository;

    public TransactionService(TransactionRepository _repository)
    {
        this.repository = _repository;
    }

    public Transaction CreatePermanent(string validSession, double total)
    {
        Transaction newTrx = new()
        {
            id_session = validSession,
            total_pay = total
        };

        repository.DB.Add(newTrx);

        return newTrx;
    }
}