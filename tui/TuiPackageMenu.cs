using System;

public static class TuiPackageMenu
{
    public static void DashboardPage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           MENU DASHBOARD          ");
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

    public static void CreateTable()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("            CREATE MENU            ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Table Number    : ");
        Console.WriteLine("Capacity      : ");
        Console.WriteLine();
        Console.WriteLine("====================================");
    }

    public static void ViewTable()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("               VIEW MENU               ");
        Console.WriteLine("========================================");
        Console.WriteLine("ID   | Name        | Capacity | Status  ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
    }

    public static void UpdateTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           UPDATE MENU              ");
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
        Console.WriteLine("             DELETE MENU              ");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.WriteLine("Pilih ID Tabel yang Ingin Dihapus : ");
        Console.WriteLine();
        Console.WriteLine("=======================================");
    }
}