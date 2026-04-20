using System.Collections;
using System.Reflection.Emit;

namespace Core.Models;

public class DoctorsCollection : IEnumerable<Doctor>
{
    // приклад агрегації
    private List<Doctor> _doctors;
    
    // dictionary
    private Dictionary<string, Doctor> _doctorById = new Dictionary<string, Doctor>();

    public DoctorsCollection()
    {
        _doctors = new List<Doctor>();
    }

    public void AddDoctor(string id, Doctor doctor)
    {
        if(!_doctorById.ContainsKey(id))
        {
            _doctors.Add(doctor);
            _doctorById.Add(id, doctor);
        }
    }

    public void RemoveDoctor(string id)
    {
        if(_doctorById.TryGetValue(id, out Doctor doctor))
        {
            _doctors.Remove(doctor);
            _doctorById.Remove(id);
        }
    }

    public Doctor GetDoctorById(string id)
    {
        return _doctorById[id];
    }
    
    public Dictionary<string, Doctor> GetDoctorsDictionary()
    {
        return _doctorById;
    }
    
    public void PrintDoctors()
    {
        foreach (var doctor in _doctors)
        {
            Console.WriteLine(doctor);
            
        }
    }

    // инкапсуляция (List дає можливість очистити список / додати щось)
    public IEnumerable<Doctor> GetDoctors()
    {
        return _doctors;
    }

    public IEnumerator<Doctor> GetEnumerator()
    {
        foreach (var doctor in _doctors)
        {
            yield return doctor;
        }
    }

    // необхідно для IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}