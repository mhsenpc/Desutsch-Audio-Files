using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class DatabaseProvider
    {
        protected IMongoDatabase GetDatabase()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mohsen:123@cluster0.9dyhfsw.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            return client.GetDatabase("deaustchdb");
        }

        protected IMongoCollection<Course> GetCollection()
        {
            return this.GetDatabase().GetCollection<Course>("courses");
        }

        public  List<Course> GetCourses()
        {
            var filter = Builders<Course>.Filter.Empty;
            var collection = GetCollection();
            var courses = collection.Find<Course>(filter).ToList();
            return courses; ;
        }

        public void UpdateCourse(Course course)
        {
            var db = GetDatabase();
            var filter = Builders<Course>.Filter.Eq(s => s._id, course._id);
            GetCollection().ReplaceOne(filter, course);
        }

        public void StoreMany(List<Course> courses)
        {
            GetCollection().InsertMany(courses);
        }
    }
}
