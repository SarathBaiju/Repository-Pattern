using MongoDB.Driver;
using RepositoryPattern.Models;
using System.Collections.Generic;

namespace RepositoryPattern.DataAccess
{
    public class MongoContext
    {
        public readonly IMongoCollection<Student> students;
        public MongoContext(IMongoDatabaseSettings mongoDatabaseSettings)
        {
            var client = new MongoClient(mongoDatabaseSettings.connectionString);
            var database = client.GetDatabase(mongoDatabaseSettings.databaseName);

            students = database.GetCollection<Student>(mongoDatabaseSettings.collectionName);
        }
        public List<Student> GetStudents()
        {

            //students.InsertOne(new Student { Id = 1, Name = "Shyam" });
            return students.Find(FilterDefinition<Student>.Empty).ToList();
        }

    }

    public class MongoDatabaseSettings: IMongoDatabaseSettings
    {
       public string collectionName { get; set; }
       public string connectionString { get; set; }
       public string databaseName { get; set; }
    }
    public interface IMongoDatabaseSettings
    {
        string collectionName { get; set; }
        string connectionString { get; set; }
        string databaseName { get; set; }
    }
}
