using System;

public static class TuiSession
{
    public static void DashboardPage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           SESSION DASHBOARD          ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("[1] Create Session");
        Console.WriteLine("[2] View Session");
        Console.WriteLine("[3] Update Session");
        Console.WriteLine("[4] Delete Session");
        Console.WriteLine("[0] Back / Exit");
        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("Select menu using number");
    }

    public static void CreateTable()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("            CREATE SESSION            ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Table Name    : ");
        Console.WriteLine("Capacity      : ");
        Console.WriteLine("Location      : ");
        Console.WriteLine("====================================");
    }

    public static void ViewTable()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("               VIEW TABLE               ");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("ID   | Name        | Capacity | Status  ");
        Console.WriteLine("----------------------------------------");
    }

    public static void UpdateTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           UPDATE SESSION              ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Select Table ID : ");
        Console.WriteLine();
        Console.WriteLine("New Table Name  : ");
        Console.WriteLine("New Capacity    : ");
        Console.WriteLine("New Status      : ");
        Console.WriteLine();
        Console.WriteLine("====================================");
    }

    public static void DeleteTablePage()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("             ASSIGN OFF SESSION              ");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.WriteLine("Pilih ID Tabel yang Ingin Dihapus : ");
        Console.WriteLine();
        Console.WriteLine("=======================================");
    }
}