public class TuiTable
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
        Console.WriteLine();
        Console.WriteLine("[1] Create Table");
        Console.WriteLine("[2] View Table");
        Console.WriteLine("[3] Update Table");
        Console.WriteLine("[4] Delete Table");
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
        Console.WriteLine();
        Console.WriteLine("[S] Save");
        Console.WriteLine("[C] Cancel");
        Console.WriteLine();
        Console.WriteLine("====================================");
    }

    public static void ViewTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("            VIEW TABLE               ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("ID   | Name        | Capacity | Status");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("01   | Table A     | 4        | Free");
        Console.WriteLine("02   | Table B     | 6        | Used");
        Console.WriteLine("03   | Table C     | 2        | Free");
        Console.WriteLine();
        Console.WriteLine("[1] View Detail");
        Console.WriteLine("[0] Back");
        Console.WriteLine();
        Console.WriteLine("====================================");
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
        Console.WriteLine();
        Console.WriteLine("[U] Update");
        Console.WriteLine("[C] Cancel");
        Console.WriteLine();
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
        Console.WriteLine("Are you sure?");
        Console.WriteLine();
        Console.WriteLine("[Y] Yes, Delete");
        Console.WriteLine("[N] No, Cancel");
        Console.WriteLine();
        Console.WriteLine("====================================");
    }
}