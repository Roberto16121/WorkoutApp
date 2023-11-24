using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace WorkoutApp.Scripts
{
    public class Save
    {
        string Name = "Measurements.json";
        readonly string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
       
        public void SaveMeasurements(WeightEntry entry)
        {
            App app = (App)App.Current;
            Load load = app.load;
            Name = Path.Combine(path, Name);
            List<WeightEntry> entries = new();
            if (File.Exists(Name))
            {
                entries = load.entries;
                if (entries[0].Date.DayOfYear == entry.Date.DayOfYear)
                    entries[0] = entry;
                else
                    entries.Insert(0, entry);
            }
            else
                entries.Insert(0,entry);
            load.entries = entries;
            string newJson = JsonConvert.SerializeObject(entries);
            using StreamWriter writer = new(Name, false);
            writer.Write(newJson);

        }
    }
}
