namespace Core.Controllers;
using Models;

public class HospitalController
{
    private Configuration _config;

    public HospitalController()
    {
        // створюється всередині = композиція
        _config = new Configuration();
    }
    
    public void PrintConfig()
    {
        Console.WriteLine(_config.ConnectionString);
    }
}
