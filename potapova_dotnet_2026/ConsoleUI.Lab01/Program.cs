using Core.Models;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World lab01!");
        
        // // task 1
        // // Отримання версії операційної системи
        // string osVersion = Environment.OSVersion.ToString();
        // Console.WriteLine($"Версія ОС: {osVersion}");
        //
        // // Створюємо масив, щоб додаток використав певний обсяг пам'яті
        // byte[] bytes = new byte[10 * 1024 * 1024];
        //
        // // Отримуємо обсяг пам'яті, який використовує додаток
        // long memoryUsed = GC.GetTotalMemory(false);
        //
        // // Переводимо байти у мегабайти
        // double memoryMB = memoryUsed / 1024.0 / 1024.0;
        //
        // Console.WriteLine($"Memory Used: {memoryMB}");
        //
        // // task 2
        // Doctor doctor = new Doctor("Ivan Petrenko", "Cardiologist", 12, 4.7);
        // doctor.IsAvailable = true;
        //
        // Patient patient = new Patient("Olena Kovalenko", new DateTime(1995, 5, 14), "+380501234567", 62.5);
        // patient.HasInsurance = true;
        //
        // Appointment appointment = new Appointment(1, 1, DateTime.Now.AddDays(2), 500);
        // appointment.IsCompleted = false;
        //
        // Console.WriteLine("Doctor:");
        // Console.WriteLine(doctor);
        //
        // Console.WriteLine("\nPatient:");
        // Console.WriteLine(patient);
        //
        // Console.WriteLine("\nAppointment:");
        // Console.WriteLine(appointment);
    }
}