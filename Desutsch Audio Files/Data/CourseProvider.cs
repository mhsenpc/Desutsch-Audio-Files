using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections;
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
        public List<Course> GetCourses() {
            var db = new DatabaseProvider();
            var courses = db.GetCourses();
            return courses;
        }

        public void UpdateCourse(Course course)
        {
            var db = new DatabaseProvider();
            db.UpdateCourse(course);
        }

        public void SeedCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("‫اشخاص","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%281%29.mp3"));
            courses.Add(new Course("‫در فرودگاه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2835%29.mp3"));
            courses.Add(new Course("‫لازم داشتن –خواستن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2869%29.mp3"));
            courses.Add(new Course("‫خانواده","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%282%29.mp3"));
            courses.Add(new Course("‫عبور و مرور درون شهری","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2836%29.mp3"));
            courses.Add(new Course("‫چیزی خواستن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2870%29.mp3"));
            courses.Add(new Course("‫آشنا شدن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%283%29.mp3"));
            courses.Add(new Course("‫در راه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2837%29.mp3"));
            courses.Add(new Course("‫چیزی خواستن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2871%29.mp3"));
            courses.Add(new Course("‫در مدرسه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%284%29.mp3"));
            courses.Add(new Course("‫در تاکسی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2838%29.mp3"));
            courses.Add(new Course("‫چیزی که باید انجام گیرد","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2872%29.mp3"));
            courses.Add(new Course("‫کشورها و زبانها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%285%29.mp3"));
            courses.Add(new Course("‫خرابی ماشین","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2839%29.mp3"));
            courses.Add(new Course("‫اجازه داشتن برای انجام","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2873%29.mp3"));
            courses.Add(new Course("‫خواندن و نوشتن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%286%29.mp3"));
            courses.Add(new Course("‫سؤال در مورد مسیر حرکت","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2840%29.mp3"));
            courses.Add(new Course("‫خواهش کردن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2874%29.mp3"));
            courses.Add(new Course("‫اعداد","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%287%29.mp3"));
            courses.Add(new Course("‫جهت یابی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2841%29.mp3"));
            courses.Add(new Course("‫دلیل آوردن برای چیزی ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2875%29.mp3"));
            courses.Add(new Course("‫ساعات روز","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%288%29.mp3"));
            courses.Add(new Course("‫بازدید از شهر","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2842%29.mp3"));
            courses.Add(new Course("‫دلیل آوردن برای چیزی ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2876%29.mp3"));
            courses.Add(new Course("‫روزهای هفته","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%289%29.mp3"));
            courses.Add(new Course("‫در باغ وحش","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2843%29.mp3"));
            courses.Add(new Course("‫دلیل آوردن برای چیزی ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2877%29.mp3"));
            courses.Add(new Course("‫دیروز –امروز –فردا","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2810%29.mp3"));
            courses.Add(new Course("‫گردش عصر (شب)","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2844%29.mp3"));
            courses.Add(new Course("‫صفت ها ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2878%29.mp3"));
            courses.Add(new Course("‫ماهها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2811%29.mp3"));
            courses.Add(new Course("‫در سینما","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2845%29.mp3"));
            courses.Add(new Course("‫صفت ها ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2879%29.mp3"));
            courses.Add(new Course("‫نوشیدنیها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2812%29.mp3"));
            courses.Add(new Course("‫در دیسکو","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2846%29.mp3"));
            courses.Add(new Course("‫صفت ها ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2880%29.mp3"));
            courses.Add(new Course("‫فعالیتها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2813%29.mp3"));
            courses.Add(new Course("‫تدارک سفر","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2847%29.mp3"));
            courses.Add(new Course("‫گذشته (زمان گذشته) ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2881%29.mp3"));
            courses.Add(new Course("‫رنگ ها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2814%29.mp3"));
            courses.Add(new Course("‫فعالیت های تعطیلاتی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2848%29.mp3"));
            courses.Add(new Course("‫گذشته (زمان گذشته) ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2882%29.mp3"));
            courses.Add(new Course("‫میوه ها و مواد غذایی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2815%29.mp3"));
            courses.Add(new Course("‫ورزش","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2849%29.mp3"));
            courses.Add(new Course("‫گذشته (زمان گذشته) ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2883%29.mp3"));
            courses.Add(new Course("‫فصل های سال و آب و هوا","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2816%29.mp3"));
            courses.Add(new Course("‫در استخر شنا","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2850%29.mp3"));
            courses.Add(new Course("‫گذشته (زمان گذشته) ۴","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2884%29.mp3"));
            courses.Add(new Course("‫در خانه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2817%29.mp3"));
            courses.Add(new Course("‫خرید مایحتاج","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2851%29.mp3"));
            courses.Add(new Course("‫سوال کردن- گذشته ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2885%29.mp3"));
            courses.Add(new Course("‫نظافت خانه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2818%29.mp3"));
            courses.Add(new Course("‫در فروشگاه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2852%29.mp3"));
            courses.Add(new Course("‫سوال کردن- گذشته ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2886%29.mp3"));
            courses.Add(new Course("‫در آشپزخانه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2819%29.mp3"));
            courses.Add(new Course("‫مغازه ها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2853%29.mp3"));
            courses.Add(new Course("‫زمان گذشته افعال معین ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2887%29.mp3"));
            courses.Add(new Course("‫گفتگوی کوتاه ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2820%29.mp3"));
            courses.Add(new Course("‫خرید","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2854%29.mp3"));
            courses.Add(new Course("‫زمان گذشته افعال معین ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2888%29.mp3"));
            courses.Add(new Course("‫گفتگوی کوتاه ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2821%29.mp3"));
            courses.Add(new Course("‫کار","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2855%29.mp3"));
            courses.Add(new Course("‫امری ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2889%29.mp3"));
            courses.Add(new Course("‫گفتگوی کوتاه ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2822%29.mp3"));
            courses.Add(new Course("‫احساس ها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2856%29.mp3"));
            courses.Add(new Course("‫امری ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2890%29.mp3"));
            courses.Add(new Course("‫یادگیری زبانهای خارجی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2823%29.mp3"));
            courses.Add(new Course("‫در مطب دکتر","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2857%29.mp3"));
            courses.Add(new Course("‫جملات وابسته با که ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2891%29.mp3"));
            courses.Add(new Course("‫قرار ملاقات","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2824%29.mp3"));
            courses.Add(new Course("‫اعضا بدن","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2858%29.mp3"));
            courses.Add(new Course("‫جملات وابسته با که ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2892%29.mp3"));
            courses.Add(new Course("‫در شهر","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2825%29.mp3"));
            courses.Add(new Course("‫در اداره پست","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2859%29.mp3"));
            courses.Add(new Course("‫جملات وابسته با آیا","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2893%29.mp3"));
            courses.Add(new Course("‫در طبیعت","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2826%29.mp3"));
            courses.Add(new Course("‫در بانک","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2860%29.mp3"));
            courses.Add(new Course("‫حروف ربط ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2894%29.mp3"));
            courses.Add(new Course("‫در هتل –ورود به هتل","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2827%29.mp3"));
            courses.Add(new Course("‫اعداد ترتیبی","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2861%29.mp3"));
            courses.Add(new Course("‫حروف ربط ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2895%29.mp3"));
            courses.Add(new Course("‫در هتل –شکایت","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2828%29.mp3"));
            courses.Add(new Course("‫سئوال کردن ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2862%29.mp3"));
            courses.Add(new Course("‫حروف ربط ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2896%29.mp3"));
            courses.Add(new Course("‫دررستوران ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2829%29.mp3"));
            courses.Add(new Course("‫سئوال کردن ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2863%29.mp3"));
            courses.Add(new Course("‫حروف ربط ۴","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2897%29.mp3"));
            courses.Add(new Course("‫در رستوران ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2830%29.mp3"));
            courses.Add(new Course("‫نفی ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2864%29.mp3"));
            courses.Add(new Course("‫حروف ربط مضاعف","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2898%29.mp3"));
            courses.Add(new Course("‫در رستوران ۳","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2831%29.mp3"));
            courses.Add(new Course("‫نفی ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2865%29.mp3"));
            courses.Add(new Course("‫حالت اضافه","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2899%29.mp3"));
            courses.Add(new Course("‫در رستوران ۴","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2832%29.mp3"));
            courses.Add(new Course("‫ضمائر ملکی ۱","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2866%29.mp3"));
            courses.Add(new Course("‫قیدها","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%28100%29.mp3"));
            courses.Add(new Course("‫در ایستگاه قطار","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2833%29.mp3"));
            courses.Add(new Course("‫ضمائر ملکی ۲","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2867%29.mp3"));
            courses.Add(new Course("‫در قطار","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2834%29.mp3"));
            courses.Add(new Course("‫بزرگ –کوچک","https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29%20%2868%29.mp3"));

            var db = new DatabaseProvider();
            db.StoreMany(courses);
        }


    }
}
