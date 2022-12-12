using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Phone
    {
        [Key]
        [Column("PhoneId")]
        public Guid PhoneId { get; set; }


        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public string PhoneNumber { get; set; }

        

    }
}
