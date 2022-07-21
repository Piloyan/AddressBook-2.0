using System.ComponentModel.DataAnnotations;

namespace AddressBook_2._0.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
