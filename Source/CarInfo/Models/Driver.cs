using System.ComponentModel.DataAnnotations;
using Models.Contracts;

namespace Models
{
    public class Driver : IDriver
    {
        public Driver()
        {
                
        }

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CarId { get; set; }

        public virtual ICar Car { get; set; }
    }
}
