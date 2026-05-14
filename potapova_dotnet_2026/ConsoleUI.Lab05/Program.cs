namespace ConsoleUI.Lab5;

using Core.Models;
using Core.Services;

class Program
{
    static void Main()
    {
        var doctors = new List<Doctor>
        {
            new Doctor("Ivan", "Cardiologist", 10, 4.5) { IsAvailable = true },
            new Doctor("Anna", "Dentist", 5, 3.8) { IsAvailable = false }
        };

        string jsonPath = "doctors.json";
        string xmlPath = "doctors.xml";

        // JSON save
        JsonService.SaveToFile(doctors, jsonPath);

        // JSON load
        var loadedDoctors = JsonService.LoadFromFile<Doctor>(jsonPath);

        // XML export
        XmlService.ExportDoctorsToXml(loadedDoctors, xmlPath);

        // using + IDisposable
        using (var logger = new ResourceManager("log.txt"))
        {
            logger.Log("Application started");
            logger.Log("Doctors saved and exported");
        }
    }
}