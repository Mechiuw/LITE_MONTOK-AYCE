public class Session
{
    public string id = Guid.NewGuid().ToString();
    public int total_person;
    public string id_current_table;
    public List<string> id_package;
    public DateTime start_time;
    public DateTime? end_time;
    public List<string> penalties;
    public bool open_status;
    
} // lanjutin ini session dan transaction