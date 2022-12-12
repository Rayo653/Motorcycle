using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace MotorcycleCompany
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Agency, AgencyDto>();
            CreateMap<Phone, PhoneDto>();
                //.ForCtorParam("FullDirection", opt => opt.MapFrom(x => string.Join(' ', x.Name, x.Address, x.Population)));
        }
    }
}
