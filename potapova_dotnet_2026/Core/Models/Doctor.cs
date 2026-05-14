namespace Core.Models;
using Core.Interfaces;
public class Doctor : MedicalEntity, ICompute
{
    private string _name;
    private string _specialization;
    private int _experienceYears;
    private bool _isAvailable;
    private double _rating;

    public string Name
    {
        get { return _name; }
        set { if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2) _name = value; }
    }

    public string Specialization
    {
        get { return _specialization; }
        set { if (!string.IsNullOrWhiteSpace(value)) _specialization = value; }
    }

    public int ExperienceYears
    {
        get { return _experienceYears; }
        set { if (value >= 0 && value <= 60) _experienceYears = value; }
    }

    public bool IsAvailable
    {
        get { return _isAvailable; }
        set { _isAvailable = value; }
    }

    public double Rating
    {
        get { return _rating; }
        set { if (value >= 0 && value <= 5) _rating = value; }
    }

    public Doctor() { }

    public Doctor(string name, string specialization, int experienceYears, double rating)
    {
        Name = name;
        Specialization = specialization;
        ExperienceYears = experienceYears;
        Rating = rating;
    }

    public override string ToString()
    {
        return $"Doctor: {Name}\nSpecialization: {Specialization}\nExperience: {ExperienceYears} years\nRating: {Rating}\nAvailable: {(IsAvailable ? "Yes" : "No")}";
    }

    public override string GetInfo()
    {
        return $"Doctor: {Name}";
    }

    public override decimal GetCost()
    {
        return (decimal)(Rating * 100);
    }
    
    public decimal Compute()
    {
        return (decimal)(Rating * 100);
    }
}