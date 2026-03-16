namespace Core.Models;

public class Patient
{
    private string _fullName;
    private DateTime _birthDate;
    private string _phone;
    private double _weight;
    private bool _hasInsurance;

    public string FullName
    {
        get { return _fullName; }
        set { if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2) _fullName = value; }
    }

    public DateTime BirthDate
    {
        get { return _birthDate; }
        set { if (value < DateTime.Now) _birthDate = value; }
    }

    public string Phone
    {
        get { return _phone; }
        set { if (!string.IsNullOrWhiteSpace(value) && value.Length >= 5) _phone = value; }
    }

    public double Weight
    {
        get { return _weight; }
        set { if (value > 0 && value < 500) _weight = value; }
    }

    public bool HasInsurance
    {
        get { return _hasInsurance; }
        set { _hasInsurance = value; }
    }

    public Patient() { }

    public Patient(string fullName, DateTime birthDate, string phone, double weight)
    {
        FullName = fullName;
        BirthDate = birthDate;
        Phone = phone;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"Patient: {FullName}\nBirthDate: {BirthDate}\nPhone: {Phone}\nWeight: {Weight}\nInsurance: {(HasInsurance ? "Yes" : "No")}";
    }
}