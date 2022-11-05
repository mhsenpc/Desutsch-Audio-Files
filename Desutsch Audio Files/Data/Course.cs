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
        public Course(string name, string url, int currentStage = 1)
        {
            Name = name;
            Url = url;
            CurrentStage = currentStage;
        }

        public string Name { get; set; }
        public string Url { get; set; }

        public int CurrentStage { get; set; }

        public bool _ { get; set; } = true;

        public ObjectId _id { get; set; }

        public string DeviceId;
    }
}
