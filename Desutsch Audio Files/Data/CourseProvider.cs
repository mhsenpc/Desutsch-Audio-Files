using Newtonsoft.Json;
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
                    
                    Preferences.Set("course", JsonConvert.SerializeObject(courses));
                    return courses;
                }
                else
                {
                    //unserialize from config
                    var courses = (List<Course>)JsonConvert.DeserializeObject(CoursesFromConfig);
                    return courses;

                }
            } 
        }

        public void SaveCourse(Course NewCourse)
        {
            int index = this.Courses.FindIndex(s => s.Url == NewCourse.Url);
            if (index != -1)
                this.Courses[index] = NewCourse;
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
