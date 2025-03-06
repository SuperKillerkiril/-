namespace AutoRepairJsonWersion.Components.Models;

public class AutoRepairService
{
    public AutoRepairService(string serviceName, DateTime startTime, DateTime endTime, Client requesterClient, bool autoRepairCompleted)
    {
        ServiceName = serviceName;
        StartTime = startTime;
        EndTime = endTime;
        RequesterClient = requesterClient;
        AutoRepairCompleted = autoRepairCompleted;
    }

    public string ServiceName { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Client RequesterClient { get; set; }
    public bool AutoRepairCompleted { get; set; }
    
}