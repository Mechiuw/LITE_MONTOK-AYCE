public class Router
{
    private readonly TuiDashboard _dashboard;

    public Router(TuiDashboard dashboard)
    {
        _dashboard = dashboard;
    }

    public void Route() // top abstract/general dispatcher
    {
        bool trigger = true;
        while(trigger)
        {
            _dashboard.MainBoard();
            var input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    HandleTableRoute();
                    break;
                case "2":
                    HandleMenuRoute();
                    break;
                case "3":
                    HandlePenaltyRoute();
                    break;
                case "4":
                    HandleSessionRoute();
                    break;
                case "5":
                    HandleTrxRoute();
                    break;
                case "6" :
                    Console.WriteLine("[EXIT] Exited program");
                    trigger = false;
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }

    public static void HandleTableRoute(){}
    public static void HandleMenuRoute(){}
    public static void HandleSessionRoute(){}
    public static void HandlePenaltyRoute(){}
    public static void HandleTrxRoute(){}
}