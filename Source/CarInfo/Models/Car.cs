using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contracts;

namespace Models
{
    public class Car : ICar
    {
        private ICollection<IDriver> drivers;

        public Car()
        {
            this.drivers = new HashSet<IDriver>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        public string VinNumber { get; set; }

        public DateTime YearOfProduction { get; set; }

        public DateTime TechnicalInspectionDueDate { get; set; }

        public DateTime PrimaryInsuranceDueDate { get; set; }

        public DateTime? AdditionalInsuranceDueDate { get; set; }

        public virtual ICollection<IDriver> Drivers
        {
            get { return this.drivers; }
            set { this.drivers = value; }
        }
    }
}
