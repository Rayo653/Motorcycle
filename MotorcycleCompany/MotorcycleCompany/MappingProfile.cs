using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace MotorcycleCompany
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<Agency, AgencyDto>()
                .ForCtorParam("FullDirection", opt => opt.MapFrom(x => string.Join(' ', x.Name, x.Population)));


                
        }

    }
}
