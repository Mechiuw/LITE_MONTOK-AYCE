public class InputMachine
{
    public static string Engine()
    {
        Boolean trigger = true;
        while (trigger)
        {
            Console.Write(">");
            string? input = Console.ReadLine();
            if (input == ":!Q")
            {
                break;
            }
        }
        return "[EXIT] SUCCESS EXITED FROM PROGRAM";
    }
}