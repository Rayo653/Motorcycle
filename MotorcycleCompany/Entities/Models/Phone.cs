using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Phone
    {
        [Key]
        [Column("PhoneId")]
        public int PhoneId { get; set; }

        [Key]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string NameAgency { get; set; }

        
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public int PhoneNumber { get; set; }

    }
}
