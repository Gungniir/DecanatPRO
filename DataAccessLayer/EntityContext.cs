using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    public class EntityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}