using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rent
    {
        [Key]
        [Column("RentId")]
        public int RentId { get; set; }
        [Key]
        [MaxLength(20, ErrorMessage = "Maximun length for the number plate is 20 characteres")]
        public string NumberPlate { get; set; }

        [Key]
        [MaxLength(60, ErrorMessage = "Maximun length for the Agency's Name is 60 characteres")]
        public string NameAgency { get; set; }

        [Key]
        [MaxLength(60, ErrorMessage = "Maximun length for the DNI Client is 60 characteres")]
        public string DNIClient { get; set; }

        [Required(ErrorMessage = "DateS name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Start Date is 20 characteres")]
        public DateTime DateS { get; set; }

        [Required(ErrorMessage = "DateE name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the End Date is 20 characteres")]
        public DateTime DateE { get; set; }

        [Required(ErrorMessage = "DateR name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Registration Date is 20 characteres")]
        public DateTime DateR { get; set; }

        [Required(ErrorMessage = "Price name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Price is 60 characteres")]
        public double Price { get; set; }

        [Required(ErrorMessage = "PaidOut name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Paid is 60 characteres")]
        public string Paid { get; set; }

        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        
    }
}
