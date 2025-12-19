public class SessionHandler
{
    private readonly SessionService _service;
    public SessionHandler(SessionService service)
    {
        _service = service;
    }

    public void Handle()
    {
        bool inSession = true;
        while(inSession)
        {
            TuiPackageMenu.DashboardPage();
            var input = Console.ReadLine();
            switch(input)
            {
                case "1": _service.Create(); break;
                case "2A": _service.FindActiveSession(); break;
                case "2B": _service.FindSession(); break;
                case "3": _service.EndSession(); break;
                case "0": inSession = false; break; // Back ke router
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}