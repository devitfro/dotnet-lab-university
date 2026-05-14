namespace Core.Models;

public class Hospital
{
    public List<Doctor> Doctors { get; set; }
    
    public Hospital(List<Doctor> doctors)
    {
        Doctors = doctors;
    }
}
