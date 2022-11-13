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
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            courses.Add(new Course("‫اشخاص", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %281%29.mp3", 1));
            courses.Add(new Course("‫خانواده", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %282%29.mp3", 2));
            courses.Add(new Course("‫آشنا شدن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %283%29.mp3", 3));
            courses.Add(new Course("‫در مدرسه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %284%29.mp3", 4));
            courses.Add(new Course("‫کشورها و زبانها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %285%29.mp3", 5));
            courses.Add(new Course("‫خواندن و نوشتن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %286%29.mp3", 6));
            courses.Add(new Course("‫اعداد", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %287%29.mp3", 7));
            courses.Add(new Course("‫ساعات روز", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %288%29.mp3", 8));
            courses.Add(new Course("‫روزهای هفته", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %289%29.mp3", 9));
            courses.Add(new Course("‫دیروز –امروز –فردا", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2810%29.mp3", 10));
            courses.Add(new Course("‫ماهها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2811%29.mp3", 11));
            courses.Add(new Course("‫نوشیدنیها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2812%29.mp3", 12));
            courses.Add(new Course("‫فعالیتها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2813%29.mp3", 13));
            courses.Add(new Course("‫رنگ ها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2814%29.mp3", 14));
            courses.Add(new Course("‫میوه ها و مواد غذایی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2815%29.mp3", 15));
            courses.Add(new Course("‫فصل های سال و آب و هوا", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2816%29.mp3", 16));
            courses.Add(new Course("‫در خانه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2817%29.mp3", 17));
            courses.Add(new Course("‫نظافت خانه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2818%29.mp3", 18));
            courses.Add(new Course("‫در آشپزخانه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2819%29.mp3", 19));
            courses.Add(new Course("‫گفتگوی کوتاه 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2820%29.mp3", 20));
            courses.Add(new Course("‫گفتگوی کوتاه 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2821%29.mp3", 21));
            courses.Add(new Course("‫گفتگوی کوتاه 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2822%29.mp3", 22));
            courses.Add(new Course("‫یادگیری زبانهای خارجی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2823%29.mp3", 23));
            courses.Add(new Course("‫قرار ملاقات", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2824%29.mp3", 24));
            courses.Add(new Course("‫در شهر", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2825%29.mp3", 25));
            courses.Add(new Course("‫در طبیعت", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2826%29.mp3", 26));
            courses.Add(new Course("‫در هتل –ورود به هتل", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2827%29.mp3", 27));
            courses.Add(new Course("‫در هتل –شکایت", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2828%29.mp3", 28));
            courses.Add(new Course("‫دررستوران 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2829%29.mp3", 29));
            courses.Add(new Course("‫در رستوران 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2830%29.mp3", 30));
            courses.Add(new Course("‫در رستوران 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2831%29.mp3", 31));
            courses.Add(new Course("‫در رستوران 4", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2832%29.mp3", 32));
            courses.Add(new Course("‫در ایستگاه قطار", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2833%29.mp3", 33));
            courses.Add(new Course("‫در قطار", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2834%29.mp3", 34));
            courses.Add(new Course("‫در فرودگاه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2835%29.mp3", 35));
            courses.Add(new Course("‫عبور و مرور درون شهری", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2836%29.mp3", 36));
            courses.Add(new Course("‫در راه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2837%29.mp3", 37));
            courses.Add(new Course("‫در تاکسی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2838%29.mp3", 38));
            courses.Add(new Course("‫خرابی ماشین", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2839%29.mp3", 39));
            courses.Add(new Course("‫سؤال در مورد مسیر حرکت", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2840%29.mp3", 40));
            courses.Add(new Course("‫جهت یابی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2841%29.mp3", 41));
            courses.Add(new Course("‫بازدید از شهر", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2842%29.mp3", 42));
            courses.Add(new Course("‫در باغ وحش", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2843%29.mp3", 43));
            courses.Add(new Course("‫گردش عصر (شب)", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2844%29.mp3", 44));
            courses.Add(new Course("‫در سینما", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2845%29.mp3", 45));
            courses.Add(new Course("‫در دیسکو", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2846%29.mp3", 46));
            courses.Add(new Course("‫تدارک سفر", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2847%29.mp3", 47));
            courses.Add(new Course("‫فعالیت های تعطیلاتی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2848%29.mp3", 48));
            courses.Add(new Course("‫ورزش", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2849%29.mp3", 49));
            courses.Add(new Course("‫در استخر شنا", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2850%29.mp3", 50));
            courses.Add(new Course("‫خرید مایحتاج", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2851%29.mp3", 51));
            courses.Add(new Course("‫در فروشگاه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2852%29.mp3", 52));
            courses.Add(new Course("‫مغازه ها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2853%29.mp3", 53));
            courses.Add(new Course("‫خرید", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2854%29.mp3", 54));
            courses.Add(new Course("‫کار", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2855%29.mp3", 55));
            courses.Add(new Course("‫احساس ها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2856%29.mp3", 56));
            courses.Add(new Course("‫در مطب دکتر", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2857%29.mp3", 57));
            courses.Add(new Course("‫اعضا بدن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2858%29.mp3", 58));
            courses.Add(new Course("‫در اداره پست", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2859%29.mp3", 59));
            courses.Add(new Course("‫در بانک", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2860%29.mp3", 60));
            courses.Add(new Course("‫اعداد ترتیبی", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2861%29.mp3", 61));
            courses.Add(new Course("‫سئوال کردن 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2862%29.mp3", 62));
            courses.Add(new Course("‫سئوال کردن 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2863%29.mp3", 63));
            courses.Add(new Course("‫نفی 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2864%29.mp3", 64));
            courses.Add(new Course("‫نفی 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2865%29.mp3", 65));
            courses.Add(new Course("‫ضمائر ملکی 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2866%29.mp3", 66));
            courses.Add(new Course("‫ضمائر ملکی 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2867%29.mp3", 67));
            courses.Add(new Course("‫بزرگ –کوچک", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2868%29.mp3", 68));
            courses.Add(new Course("‫لازم داشتن –خواستن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2869%29.mp3", 69));
            courses.Add(new Course("‫چیزی خواستن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2870%29.mp3", 70));
            courses.Add(new Course("‫چیزی خواستن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2871%29.mp3", 71));
            courses.Add(new Course("‫چیزی که باید انجام گیرد", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2872%29.mp3", 72));
            courses.Add(new Course("‫اجازه داشتن برای انجام", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2873%29.mp3", 73));
            courses.Add(new Course("‫خواهش کردن", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2874%29.mp3", 74));
            courses.Add(new Course("‫دلیل آوردن برای چیزی 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2875%29.mp3", 75));
            courses.Add(new Course("‫دلیل آوردن برای چیزی 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2876%29.mp3", 76));
            courses.Add(new Course("‫دلیل آوردن برای چیزی 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2877%29.mp3", 77));
            courses.Add(new Course("‫صفت ها 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2878%29.mp3", 78));
            courses.Add(new Course("‫صفت ها 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2879%29.mp3", 79));
            courses.Add(new Course("‫صفت ها 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2880%29.mp3", 80));
            courses.Add(new Course("‫گذشته (زمان گذشته) 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2881%29.mp3", 81));
            courses.Add(new Course("‫گذشته (زمان گذشته) 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2882%29.mp3", 82));
            courses.Add(new Course("‫گذشته (زمان گذشته) 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2883%29.mp3", 83));
            courses.Add(new Course("‫گذشته (زمان گذشته) 4", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2884%29.mp3", 84));
            courses.Add(new Course("‫سوال کردن- گذشته 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2885%29.mp3", 85));
            courses.Add(new Course("‫سوال کردن- گذشته 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2886%29.mp3", 86));
            courses.Add(new Course("‫زمان گذشته افعال معین 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2887%29.mp3", 87));
            courses.Add(new Course("‫زمان گذشته افعال معین 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2888%29.mp3", 88));
            courses.Add(new Course("‫امری 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2889%29.mp3", 89));
            courses.Add(new Course("‫امری 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2890%29.mp3", 90));
            courses.Add(new Course("‫جملات وابسته با که 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2891%29.mp3", 91));
            courses.Add(new Course("‫جملات وابسته با که 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2892%29.mp3", 92));
            courses.Add(new Course("‫جملات وابسته با آیا", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2893%29.mp3", 93));
            courses.Add(new Course("‫حروف ربط 1", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2894%29.mp3", 94));
            courses.Add(new Course("‫حروف ربط 2", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2895%29.mp3", 95));
            courses.Add(new Course("‫حروف ربط 3", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2896%29.mp3", 96));
            courses.Add(new Course("‫حروف ربط 4", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2897%29.mp3", 97));
            courses.Add(new Course("‫حروف ربط مضاعف", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2898%29.mp3", 98));
            courses.Add(new Course("‫حالت اضافه", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %2899%29.mp3", 99));
            courses.Add(new Course("‫قیدها", "https://dl.charbzaban.com/nosrat/german/german%28www.Charbzaban.com%29 %28100%29.mp3", 100));


            return courses;
        }
    }
}
