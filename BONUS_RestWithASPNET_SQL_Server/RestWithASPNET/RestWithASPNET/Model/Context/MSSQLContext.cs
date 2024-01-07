using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET.Model.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext()
        {

        }

        public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> User { get; set; }
    }
}
