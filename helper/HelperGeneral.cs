
public class HelperGeneral<T> 
{
    public static int FindAnyListIndex(
        List<T> listType,
        Func<T, string> selector,
        string requestId) 
    {
        return listType.FindIndex(x => selector(x) == requestId);
    }
    public static T ValidateSearchOutput(bool trigger,T request)
    {
        if(trigger == false)
        {
            Console.WriteLine(request);
            return request;
        } 
        return request;
    }

    public static void Testing()
    {
        
    }
}
