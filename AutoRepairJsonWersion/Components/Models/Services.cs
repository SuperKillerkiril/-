namespace AutoRepairJsonWersion.Components.Models;

public class Services
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public bool Completed { get; set; }

    public Services(string name, DateTime startDate, bool completed)
    {
        Name = name;
        StartDate = startDate;
        Completed = completed;
    }
}
