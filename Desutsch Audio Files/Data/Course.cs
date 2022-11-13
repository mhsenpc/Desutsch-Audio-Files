using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class Course
    {

        public Course(string name, string url, int index)
        {
            Name = name;
            Url = url;
            Index = index;
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public int Index { get; }

        public int CurrentStage {
            get
            {
                return Preferences.Get(Name, 1);
            }
            set
            {
                Preferences.Set(Name, value);
            }
        }
    }
}
