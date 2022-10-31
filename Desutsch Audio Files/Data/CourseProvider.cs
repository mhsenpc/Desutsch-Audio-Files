using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class CourseProvider
    {
        public static List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add( new Course("اشخاص", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%281%29.mp3"));
            courses.Add( new Course("خانواده", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%282%29.mp3"));

            return courses;
        }
    }
}
