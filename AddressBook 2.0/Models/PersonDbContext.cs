using Microsoft.EntityFrameworkCore;

namespace AddressBook_2._0.Models
{
    public class PersonDbContext:DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext>options):base(options)
        {
                
        }
        public DbSet<Person> Persons { get; set; }
    }
}
