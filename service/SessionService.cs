public class SessionService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly SessionRepository repository;
    private readonly PackageMenuRepository packageMenuRepository;
    private readonly PenaltyRepository penaltyRepository;
    public SessionService(SessionRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================

    public Session Create(Session sessionRequest)
    {
        string id = Guid.NewGuid().ToString();
        foreach (string item in sessionRequest.id_package)
        {
            if(item == packageMenuRepository.DB.ForEach(x => x.id ))
            {
                
            }
        }
        return null;
    }
    public Session FindSession(string id){return null;}
    public List<Session> FindAllSession(){return repository.DB;}
    public Session UpdateSession(Session sessionRequest){return null;}
    public void DeleteSession(string id){}
}