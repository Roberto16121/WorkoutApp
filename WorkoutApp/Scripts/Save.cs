using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace WorkoutApp.Scripts
{
    internal class Save
    {
        string Name = "Measurements.json";
        readonly string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
       
        public bool SaveMeasurements(WeightEntry entry)
        {
            Name = Path.Combine(path, Name);
            List<WeightEntry> entries = new();
            if (File.Exists(Name))
            {
                string json = File.ReadAllText(Name);
                entries = JsonConvert.DeserializeObject<List<WeightEntry>>(json);
            }
            entries.Insert(0,entry);
            string newJson = JsonConvert.SerializeObject(entries);
            using StreamWriter writer = new(Name, false);
            writer.Write(newJson);


            return false;
        }
    }
}
