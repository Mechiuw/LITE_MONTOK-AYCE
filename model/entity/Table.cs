public class Table 
{
    public string table_num;
    public string id_session;
    public ETableStatus status;

    public static Table Empty()
    {
        return new Table
        {
          table_num = "empty",
          id_session = "empty",
          status = ETableStatus.BLANK
        };
    }

    public static Table NotFoundQuery()
    {
        return new Table
        {
          table_num = "not found",
          id_session = "not found",
          status = ETableStatus.BLANK  
        };
    }
}