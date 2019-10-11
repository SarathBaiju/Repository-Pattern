using RepositoryPattern.Models;
using System.Collections.Generic;

namespace RepositoryPattern.DataAccess
{
    public interface IRepository
    {
        List<Student> GetStudents();
    }
}
