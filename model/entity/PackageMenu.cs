public class PackageMenu
{
    public string id;
    public EMenuType menu_type;
    public string name;
    public int time;
    public double price;

    public static PackageMenu Empty()
    {
        return new()
        {
          id = "",
          menu_type = EMenuType.BLANK,
          name = "",
          time = 0,
          price = 0.00
        };
    }
}