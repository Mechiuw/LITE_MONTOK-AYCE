public class TrxHandler
{
    private readonly TransactionService _service;
    public TrxHandler(TransactionService service)
    {
        _service = service;
    }
    public void Handle()
    {
        bool inTrx = true;
        while(inTrx)
        {
            TuiPackageMenu.DashboardPage();
            var input = Console.ReadLine();
            switch(input)
            {
                case "1": _service.CreatePermanent(); break;
                case "0": inTrx = false; break; // Back ke router
                default: Console.WriteLine("Invalid"); break;
            }
        }
    }
}