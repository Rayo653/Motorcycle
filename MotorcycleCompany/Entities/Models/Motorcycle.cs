using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Motorcycle
    {
        [Key]
        [Column("MotorcycleId")]
        public int MotorcycleId { get; set; }

        [Key]
        [Required(ErrorMessage = "Mat name is required field")]
        [MaxLength(10, ErrorMessage = "Maximun length for the mat is 10 characteres")]
        public string Mat { get; set; }

        [Required(ErrorMessage = "NumBast name is required field")]
        [MaxLength(30, ErrorMessage = "Maximun length for the numbast is 30 characteres")]
        public string NumBast { get; set; }

        [Required(ErrorMessage = "Color name is required field")]
        [MaxLength(50, ErrorMessage = "Maximun length for the color is 50 characteres")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Brand is required field")]
        [MaxLength(50, ErrorMessage = "Maximun length for the brand is 50 characteres")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model is required field")]    
        [MaxLength(50, ErrorMessage = "Maximun length for the model is 50 characteres")]
        public string Model { get; set; }

        [Required(ErrorMessage = "CP name is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public int CP { get; set; }

        [Required(ErrorMessage = "Address name is required field")]
        [MaxLength(100, ErrorMessage = "Maximun length for the Name is 100 characteres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Num is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the Name is 20 characteres")]
        public int Num { get; set; }

        [Required(ErrorMessage = "Date is required field")]
        [MaxLength(20, ErrorMessage = "Maximun length for the date is 20 characteres")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "NameAgency name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun length for the Name is 60 characteres")]
        public string NameAgency { get; set; }

        public int GarageId { get; set; }
        public Garage Garage { get; set; }

        public int AgencyId { get; set; }
        public Agency Agency { get; set; }

        public ICollection<Rent> Rent { get; set; }

    }
}
