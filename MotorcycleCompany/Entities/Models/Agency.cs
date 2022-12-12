using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Agency
    {
        [Key]
        [Column("AgencyId")]
        public Guid AgencyId { get; set; }

        [Required(ErrorMessage = "Agency's name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address name is required field")]
        [MaxLength(100, ErrorMessage = "Maximun length for the Name is 100 characteres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Population name is required field")]
        [MaxLength(100, ErrorMessage = "Maximun length for the Name is 100 characteres")]
        public string Population { get; set; }

        public ICollection<Motorcycle> Motorcycle { get; set; }
        public ICollection<Rent> Rents { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public int NameAgency { get; set; }
        


    }
}
