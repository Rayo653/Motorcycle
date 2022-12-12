using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IManagerService
    {
        IAgencyService AgencyService { get; }
        ICityService CityService { get; }
        IClientService ClientService { get; }
        IGarageService GarageService { get; }
        IMotorcycleService MotorcycleService { get; }
        IPhoneService PhoneService { get; }
        IRentService RentService { get; }
    }
}
