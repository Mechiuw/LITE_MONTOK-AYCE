using System;

public static class TuiPenalty
{
    public static void DashboardPage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           PENALTY DASHBOARD          ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("[1] Create Penalty");
        Console.WriteLine("[2A] View Penalty");
        Console.WriteLine("[2B] View All Penalty");
        Console.WriteLine("[3] Update Penalty");
        Console.WriteLine("[4] Delete Penalty");
        Console.WriteLine("[0] Back / Exit");
        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("Select menu using number");
    }

    public static void CreateTable()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("            CREATE PENALTY            ");
        Console.WriteLine("====================================");
        Console.WriteLine("Penalty Type    : ");
        Console.WriteLine("Amount      : ");
        Console.WriteLine("====================================");
    }

    public static void ViewTable()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("               VIEW PENALTY               ");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("ID   | Penalty Type        | price ");
        Console.WriteLine("----------------------------------------");
    }

    public static void UpdateTablePage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           UPDATE PENALTY              ");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("Select Penalty ID : ");
        Console.WriteLine();
        Console.WriteLine("New Penalty Type  : ");
        Console.WriteLine("New Amount    : ");
        Console.WriteLine("====================================");
    }

    public static void DeleteTablePage()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("             DELETE PENALTY              ");
        Console.WriteLine("=======================================");
        Console.WriteLine("Pilih ID Tabel yang Ingin Dihapus : ");
        Console.WriteLine("=======================================");
    }
}