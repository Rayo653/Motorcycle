using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Client
    {
        [Key]
        [Column("ClientId")]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Client name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public int DNI { get; set; }

        [Required(ErrorMessage = "Name name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "FirstName name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string FirstSurname { get; set; }

        [MaxLength(60, ErrorMessage = "SecondName length for the Name is 60 characteres")]
        public string? SecondSurname { get; set; }

        [Required(ErrorMessage = "Address name is required field")]
        [MaxLength(100, ErrorMessage = "Maximun length for the Name is 100 characteres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public string PhoneNumber { get; set; }


        public ICollection<Rent> Rent { get; set; }

    }
}
