public class TuiDashboard
{
    public static void MainBoard(List<Session> sessions, List<Table> tables)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


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
        Console.WriteLine("        │ [1]Table  [2]Menu  [3]Session              │");
        Console.WriteLine("        │ [4]Penalty [5]Transaction                  │");
        Console.WriteLine("        └──────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("SYSTEM : RUNNING  |  VIEW : MONITORING DASHBOARD  |  v1.0.0");
        Console.WriteLine();
    }
}