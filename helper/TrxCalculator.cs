public class TrxCalculator
{
    public static double CalculatePayment(Session sessionRequest)
    {
        if(sessionRequest.penalties.Count == 0) // kalo gaada penalti
        {
            return 0;
        }

        return 0;
    } 
}