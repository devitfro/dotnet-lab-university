namespace Core.Models;

public class Appointment
{
    private int _doctorId;
    private int _patientId;
    private DateTime _appointmentDate;
    private double _price;
    private bool _isCompleted;

    public int DoctorId
    {
        get { return _doctorId; }
        set { if (value > 0) _doctorId = value; }
    }

    public int PatientId
    {
        get { return _patientId; }
        set { if (value > 0) _patientId = value; }
    }

    public DateTime AppointmentDate
    {
        get { return _appointmentDate; }
        set { if (value >= DateTime.Now) _appointmentDate = value; }
    }
    
    public double Price
    {
        get { return _price; }
        set { if (value >= 0) _price = value; }
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
        set { _isCompleted = value; }
    }

    public Appointment() { }

    public Appointment(int doctorId, int patientId, DateTime date, double price)
    {
        DoctorId = doctorId;
        PatientId = patientId;
        AppointmentDate = date;
        Price = price;
    }

    public override string ToString()
    {
        return $"DoctorId: {DoctorId}\nPatientId: {PatientId}\nDate: {AppointmentDate}\nPrice: {Price}\nCompleted: {(IsCompleted ? "Yes" : "No")}";
    }
}