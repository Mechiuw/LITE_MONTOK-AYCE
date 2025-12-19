using App.Bootstrap;

public class Program
{
    public static void Menu(String[] args)
    {
        Run();
    } 
    public static void Run()
    {
        var router = Bootstrap.AppConfig();
        router.Route();
    } 
}