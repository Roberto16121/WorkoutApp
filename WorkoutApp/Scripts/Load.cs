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
        readonly string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        public void LoadMeasurements()
        {
            string Name = "Measurements.json";
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

        public bool DoesFileExist(string name)
        {
            name = Path.Combine(path, name);
            if(File.Exists(name))
                return true;
            return false;
        }
    }
}
