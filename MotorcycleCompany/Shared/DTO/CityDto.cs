using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;
//[Serializable]
public record CityDto
  {
    public string Name { get; init; } 
    public string Province { get; init; }
    public string Residents { get; init; }


  };

    
    

