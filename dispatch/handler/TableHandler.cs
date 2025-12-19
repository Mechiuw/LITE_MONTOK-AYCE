public class TableHandler
{
    private readonly TableService _service;

    public TableHandler(TableService service)
    {
        _service = service;
    }

    public void Handle()
    {
        bool inTable = true;
        while(inTable)
        {
            TuiTable.DashboardPage();
            var input = Console.ReadLine();
            switch(input)
            {
                case "1": _service.CreateNewTable(); break;
                case "2A": _service.FindAnyTable(); break;
                case "2B": _service.FindAllTable(); break;
                case "3": _service.UpdateTable(); break;
                case "4": _service.DeleteTable(); break;
                case "5": _service.AssignTable(); break;
                case "0": inTable = false; break; // Back ke router
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}
