namespace ConsoleUI.Lab04;

using Core.Interfaces;
using Core.Controllers;
using Core.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from lab04!");

        ICompute[] items =
        {
            new Doctor { Name = "Ivan", Rating = 4.5 },
            new Appointment { Price = 200 },
            new Patient { FullName = "Anna", HasInsurance = true }
        };
        
        foreach (var item in items)
        {
            Console.WriteLine(item.Compute());
        }
    }
}