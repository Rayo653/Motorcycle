using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;
//[Serializable]
public record GarageDto
    {
        public int CP { get; init; }
        public string Address { get; init; }
        public int Num { get; init; }
        public string Name { get; init; }


};

