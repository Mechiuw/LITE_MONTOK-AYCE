public class PackageMenuHandler
{
    private readonly PackageMenuService _service;
    public PackageMenuHandler(PackageMenuService service)
    {
        _service = service;
    }
    public void Handle()
    {
        bool inMenu = true;
        while(inMenu)
        {
            TuiPackageMenu.DashboardPage();
            var input = Console.ReadLine();
            switch(input)
            {
                case "1": _service.CreateMenu(); break;
                case "2A": _service.FindAnyMenu(); break;
                case "2B": _service.FindAllMenu(); break;
                case "3": _service.UpdateMenu(); break;
                case "4": _service.DeleteMenu(); break;
                case "0": inMenu = false; break; // Back ke router
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}