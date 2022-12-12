using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO;

public record RentDto
{
    public string NumberPlate { get; init; }
    public string NameAgency { get; init; }
    public string DNIClient { get; init; }
    public DateTime DateS { get; init; }
    public DateTime DateE { get; init; }
    public DateTime DateR { get; init; }
    public string Price { get; init; }
    public string Paid { get; init; }


};
