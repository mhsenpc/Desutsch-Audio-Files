using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Desutsch_Audio_Files.Data
{
    public class CourseProvider
    {
        public List<Course> Courses { 
            get {
                var CoursesFromConfig = Preferences.Get("courses", "");
                if (CoursesFromConfig == "")
                {
                    var courses = InitialCourses();
                    //Preferences.Set("course", ObjectToString(Courses));
                    return courses;
                }
                else
                {
                    //unserialize from config
                    var courses = (List<Course>)StringToObject(CoursesFromConfig);
                    return courses;

                }
            } 
        }




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


        public List<Course> InitialCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add( new Course("اشخاص", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%281%29.mp3"));
            courses.Add( new Course("خانواده", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%282%29.mp3"));
            return courses;
        }
    }
}
