using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;
//[Serializable]
public record AgencyDto
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string Population { get; init; }
    public string Phones { get; init; }


};

