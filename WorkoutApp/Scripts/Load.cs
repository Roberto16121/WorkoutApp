using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Scripts
{
    internal class Load
    {
        string Name = "Measurements.json";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        public void LoadMeasurements()
        {
            Name = Path.Combine(path, Name);
            if(File.Exists(Name))
            {
                string json = File.ReadAllText(Name);
                List<WeightEntry> entries = JsonConvert.DeserializeObject<List<WeightEntry>>(json);
                foreach(WeightEntry entry in entries)
                {
                    Trace.WriteLine(entry.Date);
                }
            }
            else
            {
                Trace.WriteLine("File does not exist");
            }
        }
    }
}
