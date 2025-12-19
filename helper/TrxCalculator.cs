public class TrxCalculator
{
    public static double CalculatePayment(int total_person, double total_penalty, double total_package)
    {
        double total = (total_person * total_package)
        + total_penalty;

        return total;
    } 

    public static double CalculatePackage(List<PackageMenu> packageMenus)
    {
        return packageMenus.Sum(menu => menu.price);
    }
    public static double CalculatePenalty(List<Penalty> penalties)
    {
        return penalties.Sum(penalty => penalty.pay_penalty);
    }
}