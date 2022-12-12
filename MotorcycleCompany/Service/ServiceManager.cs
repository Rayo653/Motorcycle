using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {



        private readonly Lazy<IAgencyService> _agencyService;
        private readonly Lazy<ICityService> _cityService;
        private readonly Lazy<IPhoneService> _phoneService;
        private readonly Lazy<IRentService> _rentService;
        private readonly Lazy<IMotorcycleService> _motorcycleService;
        private readonly Lazy<GarageService> _garageService;
        private readonly Lazy<IClientService> _clientService;




         

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _agencyService = new Lazy<IAgencyService>(() => new AgencyService(repositoryManager, loggerManager));
            _cityService = new Lazy<ICityService>(() => new CityService(repositoryManager, loggerManager));
            _rentService = new Lazy<IRentService>(() => new RentService(repositoryManager, loggerManager));
            _phoneService = new Lazy<IPhoneService>(() => new PhoneService(repositoryManager, loggerManager));
            _motorcycleService = new Lazy<IMotorcycleService>(() => new MotorcycleService(repositoryManager, loggerManager));
            _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, loggerManager));
            _garageService = new Lazy<GarageService>(() => new GarageService(repositoryManager, loggerManager));

        }



        public IAgencyService AgencyService => _agencyService.Value;

        public ICityService CityService => _cityService.Value;

        public IClientService ClientService => _clientService.Value;

        public IPhoneService PhoneService => _phoneService.Value;

        public IRentService RentService => _rentService.Value;

        public IMotorcycleService MotorcycleService => _motorcycleService.Value;

        public IGarageService GarageService => _garageService.Value;



     

            
    }
}
