using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rent
    {
        [Column("RentId")]
        public int RentId { get; set; }
        [Key]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public string Mat { get; set; }

        [Key]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string NameAgency { get; set; }

        [Key]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string DNIClient { get; set; }

        [Required(ErrorMessage = "DateI name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public DateTime DateI { get; set; }

        [Required(ErrorMessage = "DateF name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public DateTime DateF { get; set; }


        [Required(ErrorMessage = "DateF name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public DateTime DateR { get; set; }

        [Required(ErrorMessage = "Price name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public double Price { get; set; }

        [Required(ErrorMessage = "PaidOut name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]

        public string Paid { get; set; }


        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; } 
    }
}
