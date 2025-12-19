public class PenaltyHandler
{
    private readonly PenaltyService _service;
    public PenaltyHandler(PenaltyService service)
    {
        _service = service;
    }

    public void Handle()
    {
        bool inPenalty = true;
        while (inPenalty)
        {
            TuiPenalty.DashboardPage();
            var input = Console.ReadLine();
            switch(input)
            {
                case "1": _service.CreatePenalty(); break;
                case "2A": _service.FindAnyPenalty(); break;
                case "2B": _service.FindAllPenalty(); break;
                case "3": _service.UpdatePenalty(); break;
                case "4": _service.DeletePenalty(); break;
                case "0": inPenalty = false; break; // Back ke router
                default: Console.WriteLine("Invalid"); break;
            }
        }
        
    }
}