using System.Collections.Generic;
using RepositoryPattern.Models;

namespace RepositoryPattern.DataAccess.Repository
{
    public class InMemoryCollection : IRepository
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{Id=1, Name="Sarath"},
                new Student{Id=2, Name="Sabique"},
                new Student{Id=3, Name="Jerish"}
            };
        }
    }
}
