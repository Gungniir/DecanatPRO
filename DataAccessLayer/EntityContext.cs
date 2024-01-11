using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("name=EntityContextDatabase") { }
        public DbSet<Student> Students { get; set; }
    }
}