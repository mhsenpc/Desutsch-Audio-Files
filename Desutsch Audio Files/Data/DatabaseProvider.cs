using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class DatabaseProvider
    {
        protected const string ConfigFileName = "deutsch.config";

        public string ObjectToString(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, obj);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public object StringToObject(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                ms.Write(bytes, 0, bytes.Length);
                ms.Position = 0;
                return new BinaryFormatter().Deserialize(ms);
            }
        }

        public List<Course> GetCourses()
        {
            var courses= Preferences.Get("courses", "") ;
            if(courses == "")
            {
                return new List<Course>();
            }

            return (List<Course>) StringToObject(courses);
        }

        public void UpdateCourse(Course course)
        {


        }

        public void StoreMany(List<Course> courses)
        {
            var o = ObjectToString(courses);
            Preferences.Set("courses", o);
        }
    }
}
