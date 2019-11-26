using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.Models;

namespace RepositoryPattern.DataAccess.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly SqlDbContext _sqlDbContext;

        public SqlRepository(SqlDbContext sqlDbContext)
        {
            _sqlDbContext = sqlDbContext;
        }
        public List<Student> GetStudents()
        {
            IQueryable<Student> students= _sqlDbContext.Students;
            return students.ToList();
        }
    }
}
