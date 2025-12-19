public static class TuiGeneral
{
    public static void ConfirmationSave()
    {
        Console.WriteLine("[S] Save");
        Console.WriteLine("[C] Cancel");
    }

    public static void ConfirmationUpdate()
    {
        Console.WriteLine("[U] Update");
        Console.WriteLine("[C] Cancel");
    }
    public static void ConfirmationDelete()
    {
        Console.WriteLine("Are you sure?");
        Console.WriteLine();
        Console.WriteLine("[Y] Yes, Delete");
        Console.WriteLine("[N] No, Cancel");
    }
}