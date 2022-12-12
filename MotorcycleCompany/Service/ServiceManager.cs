using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IManagerService
    {
        private readonly Lazy<IAgencyService> _agencyService;

        private readonly Lazy<ICityService> _cityService;

        private readonly Lazy<IClientService> _clientService;

        private readonly Lazy<IGarageService> _garageService;

        private readonly Lazy<IMotorcycleService> _motorcycleService;

        private readonly Lazy<IPhoneService> _phoneService;

        private readonly Lazy<IRentService> _rentService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _agencyService = new Lazy<IAgencyService>(() => new AgencyService(repositoryManager, loggerManager, mapper));
            _cityService = new Lazy<ICityService>(() => new CityService(repositoryManager, loggerManager, mapper));
            _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, loggerManager, mapper));
            _garageService = new Lazy<IGarageService>(() => new GarageService(repositoryManager, loggerManager, mapper));
            _motorcycleService = new Lazy<IMotorcycleService>(() => new MotorcycleService(repositoryManager, loggerManager, mapper));
            _phoneService = new Lazy<IPhoneService>(() => new PhoneService(repositoryManager, loggerManager, mapper));
            _rentService = new Lazy<IRentService>(() => new RentService(repositoryManager, loggerManager, mapper));
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
