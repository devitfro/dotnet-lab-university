namespace Core.Services;
using System.Text.Json;

public class JsonService
{
    private static JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public static void SaveToFile<T>(List<T> data, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            JsonSerializer.Serialize(fs, data, options);
        }
    }
    
    public static List<T> LoadFromFile<T>(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found!");
            return new List<T>();
        }

        try
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return JsonSerializer.Deserialize<List<T>>(fs, options) ?? new List<T>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while reading file: {ex.Message}");
            return new List<T>();
        }
    }
}