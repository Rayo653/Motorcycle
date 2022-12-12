using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;
//[Serializable]
public record MotorcycleDto
    {
        public string Mat { get; init; }
        public string NumBast { get; init; }
        public string Color { get; init; }
        public string Model { get; init; }
        public int CP { get; init; }
        public int Num { get; init; }
        public DateTime Date { get; init; }



};

