using System.Collections;
using System.Diagnostics;
using Core.Models;

namespace ConsoleUI.Lab02;

class Program
{
    // static void ChangePrice(Price price, decimal value, string currency)
    // {
    //     price.Amount = value;
    //     price.Currency = currency;
    //     Console.WriteLine($"Price of local copy: {price}");
    // }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World lab02!");
        // // task 2
        // var price = new Price();
        // var value = 100;
        // var currency = "USD";
        //
        // Console.WriteLine($"Price before: {price}");
        // ChangePrice(price, value, currency);
        // Console.WriteLine($"Price after: {price}");
        //
        // // task 3
        // int x = 10;
        // Object obj = x; // boxing
        //
        // // ArrayList
        // Stopwatch stopwatch = new Stopwatch();
        // ArrayList arrayList = new ArrayList();
        // stopwatch.Start();
        // for (int i = 0; i < 1000000; i++)
        // {
        //     arrayList.Add(i); // boxing
        // }
        // stopwatch.Stop();
        // long arrayListTime = stopwatch.ElapsedMilliseconds;
        // Console.WriteLine($"ArrayList: {arrayListTime} ms");
        //
        // // List<int>
        // List<int> list = new List<int>();
        // stopwatch.Restart();
        //
        // for (int i = 0; i < 1000000; i++)
        // {
        //     list.Add(i);
        // }
        // stopwatch.Stop();
        //
        // long listTime = stopwatch.ElapsedMilliseconds;
        // Console.WriteLine($"List<int>: {listTime} ms");
        // Console.WriteLine($"Difference: {arrayListTime - listTime} ms");
        //
        // // task 4
        // List<Doctor> doctors = new List<Doctor>
        // {
        //     new Doctor("Ivan O.", "Cardiologist", 10, 5),
        //     new Doctor("Inna I.", "Therapist", 1, 4.7),
        //     new Doctor("Alica N.", "Surgeon", 3, 4.9),
        //     new Doctor("Sofia M.", "Neurologist", 10, 3.9),
        //     new Doctor("Alex S.", "Dermatologist", 7, 5),
        //     new Doctor("Max M.", "Pediatrician", 10, 4.8),
        //     new Doctor("Michail K.", "Ophthalmologist", 15, 4.5),
        //     new Doctor("Anastasia A.", "Orthopedist", 11, 4.9),
        //     new Doctor("Viktor V.", "ENT", 8, 5),
        //     new Doctor("Sofia L.", "Endocrinologist", 5, 4.8)
        // };
        //
        // // task 5
        // IEnumerable<Doctor> experiencedDoctors = doctors.Where(doctor => doctor.ExperienceYears > 5);
        //
        // Console.WriteLine($"\nExperienced Doctors (>5 years): {experiencedDoctors.Count()}");
        // Console.WriteLine("{0,-15} | {1,-15} | {2,-5} | {3,-6}", "Name", "Specialty", "Exp", "Rating");
        // Console.WriteLine(new string('-', 50));
        // foreach (var doctor in experiencedDoctors)
        // {
        //     Console.WriteLine("{0,-15} | {1,-15} | {2,-5} | {3,-6}", doctor.Name, doctor.Specialization, doctor.ExperienceYears, doctor.Rating);
        // }
        //
        // // task 6
        // IEnumerable<Doctor> sortedDoctors = doctors.OrderBy(doctor => doctor.Name).ThenByDescending(doctor => doctor.Rating);
        //
        // Console.WriteLine("\nSorted Doctors (by Name, then Rating):");
        // Console.WriteLine("{0,-15} | {1,-15} | {2,-5} | {3,-6}", "Name", "Specialty", "Exp", "Rating");
        // Console.WriteLine(new string('-', 50));
        // foreach (var doctor in sortedDoctors)
        // {
        //     Console.WriteLine("{0,-15} | {1,-15} | {2,-5} | {3,-6}", doctor.Name, doctor.Specialization, doctor.ExperienceYears, doctor.Rating);
        // }
        //
        // // task 7
        // IEnumerable<string> doctorNames = doctors.Select(doctor => doctor.Name);
        //
        // Console.WriteLine("\nDoctor Names:");
        // Console.WriteLine(new string('-', 20));
        // foreach (var name in doctorNames)
        // {
        //     Console.WriteLine(name);
        // }
        //
        // // task 8
        // var uniqDoctor = doctors.FirstOrDefault(doctor => doctor.ExperienceYears == 5 && doctor.Rating >= 4).Name;
        //
        // if (uniqDoctor != null)
        // {
        //     Console.WriteLine($"\nUniq doctor: {uniqDoctor}");
        // }
        // else
        // {
        //     Console.WriteLine("\nNo doctor found matching the criteria.");
        // }
    }
}