public static class TuiTable
{
    // =========================
    // TABLE TUI
    // =========================

    // 1. DASHBOARD
    // 2. CREATE
    // 3. FIND (READ 1 / ALL)
    // 4. UPDATE
    // 5. DELETE

    public static void DashboardPage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           TABLE DASHBOARD           ");
        Console.WriteLine("====================================");
        Console.WriteLine("// MASTER DATA");
        Console.WriteLine("[1] Create Table");
        Console.WriteLine("[2] View Table");
        Console.WriteLine("[3] Update Table");
        Console.WriteLine("[4] Delete Table");
        Console.WriteLine("// BUSINESS DATA");
        Console.WriteLine("[5] Assign Table");
        Console.WriteLine("[0] Back / Exit");
        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("Select menu using number");
    }

    public static void CreateTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           CREATE TABLE              ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Table Name    : ");
        Console.WriteLine("Capacity      : ");
        Console.WriteLine("Location      : ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("====================================");
    }

    public static void ViewTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("            VIEW TABLE               ");
        Console.WriteLine("====================================");
        Console.WriteLine();
    }

    public static void UpdateTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           UPDATE TABLE              ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Select Table ID : ");
        Console.WriteLine();
        Console.WriteLine("New Table Name  : ");
        Console.WriteLine("New Capacity    : ");
        Console.WriteLine("New Status      : ");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("====================================");
    }

    public static void DeleteTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           DELETE TABLE              ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Select Table ID to Delete : ");
        Console.WriteLine();
        Console.WriteLine("====================================");
    }
}