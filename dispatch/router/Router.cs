public class Router
{
    private readonly TuiDashboard _dashboard;
    private readonly TableHandler _tableHandler;
    private readonly PackageMenuHandler _menuHandler;
    private readonly SessionHandler _sessionHandler;
    private readonly PenaltyHandler _penaltyHandler;
    private readonly TrxHandler _trxHandler;

    public Router(
        TuiDashboard dashboard,
        TableHandler tableHandler,
        PackageMenuHandler menuHandler,
        SessionHandler sessionHandler,
        PenaltyHandler penaltyHandler,
        TrxHandler trxHandler)
    {
        _dashboard = dashboard;
        _tableHandler = tableHandler;
        _menuHandler = menuHandler;
        _sessionHandler = sessionHandler;
        _penaltyHandler = penaltyHandler;
        _trxHandler = trxHandler;
    }

    public void Route()
    {
        bool running = true;
        while(running)
        {
            _dashboard.MainBoard();
            var input = Console.ReadLine();

            switch(input)
            {
                case "1": _tableHandler.Handle(); break;
                case "2": _menuHandler.Handle(); break;
                case "3": _penaltyHandler.Handle(); break;
                case "4": _sessionHandler.Handle(); break;
                case "5": _trxHandler.Handle(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Unknown command"); break;
            }
        }
    }
}
