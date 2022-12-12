using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;
//[Serializable]
public record ClientDto
    {
        public string Name { get; init; }
        public string FirtsSurname { get; init; }
        public string SecondSurname { get; init; }
        public string Address { get; init; }
        public string PhoneNumber { get; init; }



};


