using System.Collections.Generic;
using RepositoryPattern.Models;

namespace RepositoryPattern.DataAccess.Repository
{
    public class MongoRepository : IRepository
    {
        private MongoContext _mongoContext;

        public MongoRepository(MongoContext mongoContext)
        {
            _mongoContext = mongoContext;
        }
        public List<Student> GetStudents()
        {
            return _mongoContext.GetStudents();
        }
    }
}
