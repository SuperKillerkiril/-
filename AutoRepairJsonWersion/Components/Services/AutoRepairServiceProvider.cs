using AutoRepairJsonWersion.Components.Models;
using Newtonsoft.Json;

namespace AutoRepairJsonWersion.Components.Services;

public class AutoRepairServiceProvider
{
    const string PathAllServices = "AllServices.json";
    private static List<AutoRepairService>? _services = [];
    
    protected void OnInitialized()
    { OpenFile(); }
    private void OpenFile()
    {
        if (File.Exists(PathAllServices))
        { 
            var json = File.ReadAllText(PathAllServices);
            _services = JsonConvert.DeserializeObject<List<AutoRepairService>>(json); 
        }
        else
        { SaveFile(); }
    }
    public static void SaveFile()
    {
        var json = JsonConvert.SerializeObject(_services);
        File.WriteAllText(PathAllServices, json);
    }

    public static void AddService(string serviceName, DateTime startTime, DateTime endTime, Client client, bool autoRepairCompleted)
    {
        var services = new AutoRepairService(serviceName, startTime, endTime, client, autoRepairCompleted);
        _services?.Add(services);
    }
}