using System;

public class tabelTransaksi
{
    public static void Main(string[] args)
    {
        Console.Clear(); // Bersihkan konsol setiap kali menu ditampilkan (opsional, tapi bagus untuk tampilan)
        Console.WriteLine("============================================");
        Console.WriteLine("               TABEL DAFTAR SESI            ");
        Console.WriteLine("============================================");
        Console.WriteLine("| No. | Daftar Sesi                        |");
        Console.WriteLine("|-----|------------------------------------|");
        Console.WriteLine("| 1   | Tambah Tabel                       |");
        Console.WriteLine("| 2   | Tampilkan Tabel (Any/ALL)          |");
        Console.WriteLine("| 3   | Ubah Tabel                         |");
        Console.WriteLine("| 4   | Delete Tabel                       |");
        Console.WriteLine("| 5   | Keluar                             |");
        Console.WriteLine("============================================");
    }

    public static void DashboardPage()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("           TABLE DASHBOARD          ");
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
        Console.WriteLine("            CREATE TABLE            ");
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

    public static void ViewTable()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("               VIEW TABLE               ");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("ID   | Name        | Capacity | Status  ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("01   | Content A     | 4        | Free  ");
        Console.WriteLine("02   | Content B     | 6        | Used  ");
        Console.WriteLine("03   | Content C     | 2        | Free  ");
        Console.WriteLine();
        Console.WriteLine("[1] View Detail");
        Console.WriteLine("[0] Back");
        Console.WriteLine();
        Console.WriteLine("========================================");
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
        Console.WriteLine("=======================================");
        Console.WriteLine("             DELETE TABLE              ");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.WriteLine("Pilih ID Tabel yang Ingin Dihapus : ");
        Console.WriteLine();
        Console.WriteLine("Apa anda yakin?");
        Console.WriteLine();
        Console.WriteLine("[Y] Yes, Delete");
        Console.WriteLine("[N] No, Cancel");
        Console.WriteLine();
        Console.WriteLine("=======================================");
    }
}