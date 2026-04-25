using Core.Models;
using System.Xml.Linq;

namespace Core.Services;

public class XmlService
{
    public static void ExportDoctorsToXml(List<Doctor> doctors, string path)
    {
        var filteredDoctors = doctors
            .Where(d => d.Rating >= 4); // пример условия

        var xml = new XDocument(
            new XElement("Doctors",
                filteredDoctors.Select(d =>
                    new XElement("Doctor",
                        new XElement("Name", d.Name),
                        new XElement("Specialization", d.Specialization),
                        new XElement("Experience", d.ExperienceYears),
                        new XElement("Rating", d.Rating),
                        new XElement("Available", d.IsAvailable)
                    )
                )
            )
        );

        xml.Save(path);
    }
}