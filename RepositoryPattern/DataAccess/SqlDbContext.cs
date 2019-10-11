using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.DataAccess
{
    public class SqlDbContext:DbContext
    {
        public SqlDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
