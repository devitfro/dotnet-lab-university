namespace ConsoleUI.Lab03;
using Core.Models;

class Program
{
    static void Main(string[] args)
    {
        // task 2
        string text = "hello!";

        string newText = text.Capitalize();
        Console.WriteLine(newText);
        

        // task 3
        // create doctors
        Doctor neuroDoc = new Doctor("John", "neuro", 20, 5.0);
        Doctor cardioDoc = new Doctor("Bob", "cardio", 10, 4.8);
        Doctor surgeryDoc = new Doctor("Billie", "surgeon", 7, 5.0);

        // create doctors collection
        var doctorsCollection = new DoctorsCollection();
        
        doctorsCollection.AddDoctor("001", neuroDoc);
        doctorsCollection.AddDoctor("002", cardioDoc);
        doctorsCollection.AddDoctor("003", surgeryDoc);

        doctorsCollection.PrintDoctors();
        
        // task 4
        Console.WriteLine("\n======== task4: GetEnumerator========");
        foreach (var doc in doctorsCollection)
        {
            Console.WriteLine(doc);
            Console.WriteLine();
        }
        
        // task 5
        Console.WriteLine("\n======== task 5: Dictionary search (fast O(1)) ========");
        var foundedDoc = doctorsCollection.GetDoctorById("001");
        Console.WriteLine(foundedDoc);
        
        Console.WriteLine("\n======== The best of the doctors: ========");
        var bestDoctors = doctorsCollection.Where(d => d.Rating == 5.0);
        
        foreach (var doc in bestDoctors)
        {
            Console.WriteLine($"best of the doctors: {doc}");
        }
        
        // task 6
        Console.WriteLine("\n======== task 6 ========");
        HashSet<string> tags = new HashSet<string>();

        tags.Add("neuro");
        tags.Add("cardio");
        tags.Add("neuro"); // не додається

        foreach (var tag in tags)
        {
            Console.WriteLine(tag);
        }
        
        HashSet<string> hashA = new HashSet<string>()
        {
            "cardio", "neuro", "surgery"
        };

        HashSet<string> hashB = new HashSet<string>()
        {
            "neuro", "dermatology", "cardio"
        };
        
        Console.WriteLine("\nCommon HashSet:");
        var common = new HashSet<string>(hashA);
        common.IntersectWith(hashB);
        foreach (var item in common)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("\nUnion HashSet:");
        
        // variant 1
        // var union = new HashSet<string>(hashA);
        // union.UnionWith(hashB); // змінює поточний hashSet
        
        // variant 2
        var union = hashA.Union(hashB); // не змінює поточний hashSet, створює новий результат
        
        foreach (var item in union)
        {
            Console.WriteLine(item);
        }
    }
}