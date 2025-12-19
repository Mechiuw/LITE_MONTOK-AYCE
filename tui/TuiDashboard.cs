public class TuiDashboard
{
    private readonly SessionService _sessionService;
    private readonly TableService _tableService;

    public TuiDashboard(SessionService sessionService, TableService tableService)
    {
        _sessionService = sessionService;
        _tableService = tableService;
    }

    public void MainBoard()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var sessions = _sessionService.FindActiveSession();
        var tables = _tableService.FindAllTable();

        // TABLE HIGHLIGHT DATA
        int totalTable = tables.Count;
        int inUse = tables.Count(x => x.status == ETableStatus.OCCUPIED);
        int availlable = tables.Count(x => x.status == ETableStatus.AVAILLABLE);

        Console.WriteLine();
        Console.WriteLine("┌──────────────────────────────────────────────────────────────┐");
        Console.WriteLine("│ HIGHLIGHT                                                     │");
        Console.WriteLine("├──────────────────────────────────────────────────────────────┤");
        Console.WriteLine("│  OPEN SESSIONS                                               │");                                     
        foreach (Session session in sessions)
        {
            Console.WriteLine($" • {session.id} | {session.total_person} | {session.start_time} | {session.open_status} ");
        }
        Console.WriteLine("├──────────────────────────────────────────────────────────────┤");
        Console.WriteLine("│ AVAILABLE TABLE LEFT                                         │");
        Console.WriteLine($"Total : {totalTable}     In Use : {inUse}     Available : {availlable}  ");
        Console.WriteLine("└──────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("        ┌──────────────────────────────────────────┐");
        Console.WriteLine("        │ NAVIGATION                                │");
        Console.WriteLine("        ├──────────────────────────────────────────┤");
        Console.WriteLine("        │ [1]Table  [2]Menu  [3]Penalty              │");
        Console.WriteLine("        │ [4]Session [5]Transaction [6]Exit                 │");
        Console.WriteLine("        └──────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("SYSTEM : RUNNING  |  VIEW : MONITORING DASHBOARD  |  v1.0.0");
        Console.WriteLine();
    }
}
