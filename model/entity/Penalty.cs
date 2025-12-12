public class Penalty
{
    public string id = Guid.NewGuid().ToString();
    public EPenalty penalty_type;
    public double pay_penalty;
}