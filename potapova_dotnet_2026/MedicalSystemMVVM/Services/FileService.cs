using Core.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace MedicalSystemMVVM.Services
{
    public static class FileService
    {
        private static string path = "doctors.json";

        public static void Save(
            ObservableCollection<Doctor> doctors)
        {
            string json =
                JsonSerializer.Serialize(doctors);

            File.WriteAllText(path, json);
        }

        public static ObservableCollection<Doctor> Load()
        {
            if (!File.Exists(path))
            {
                return new ObservableCollection<Doctor>();
            }

            string json =
                File.ReadAllText(path);

            return JsonSerializer.Deserialize
                <ObservableCollection<Doctor>>(json);
        }
    }
}