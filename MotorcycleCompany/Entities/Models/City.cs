using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class City
    {
        [Key]
        [Column("CityId")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "City name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public int CP { get; set; }

        [Required(ErrorMessage = "City name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Providence name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Habitants name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string Residents { get; set; } 

        public ICollection<Garage> Garage { get; set; }

    }
}
