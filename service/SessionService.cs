public class SessionService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly SessionRepository repository;
    public SessionService(SessionRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================

    public Session Create(Session sessionRequest){return null;}
    public Session FindSession(string id){return null;}
    public List<Session> FindAllSession(){return repository.DB;}
    public Session UpdateSession(Session sessionRequest){return null;}
    public void DeleteSession(string id){}
}