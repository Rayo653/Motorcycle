using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Garage
    {
        [Key]
        [Column("GarageId")]
        public int GarageId { get; set; }

        [Key]
        [MaxLength(10, ErrorMessage = "Maximun length for the Name is 10 characteres")]
        public int CP { get; set; } 

        [Key]
        [MaxLength(100, ErrorMessage = "Maximun length for the Name is 100 characteres")]
        public string Address { get; set; }

        [Key]
        [MaxLength(10, ErrorMessage = "Maximun length for the number of garage is 10 characteres")]
        public int Num { get; set; }

        [Required(ErrorMessage = "Garage's name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the garage's name is 60 characteres")]
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Motorcycle> Motorcycle { get; set; }

    }
}
