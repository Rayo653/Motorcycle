using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAgency> _agency;
        private readonly Lazy<IClient> _client;
        private readonly Lazy<IMotorcycle> _motorcycle;
        private readonly Lazy<IGarage> _garage;
        private readonly Lazy<ICity> _city;
        private readonly Lazy<IRent> _rent;
        private readonly Lazy<IPhone> _phone;

        public RepositoryManager(RepositoryContext repositorycontext)
        {
            _repositoryContext = repositorycontext;
            _agency = new Lazy<IAgency>(() => new RepositoryAgency(repositorycontext));
            _client = new Lazy<IClient>(() => new RepositoryClient(repositorycontext));
            _motorcycle = new Lazy<IMotorcycle>(() => new RepositoryMotorcycle(repositorycontext));
            _garage = new Lazy<IGarage>(() => new RepositoryGarage(repositorycontext));
            _city = new Lazy<ICity>(() => new RepositoryCity(repositorycontext));
            _rent = new Lazy<IRent>(() => new RepositoryRent(repositorycontext));
            _phone = new Lazy<IPhone>(() => new RepositoryPhone(repositorycontext)); 
        }

        public IAgency Agency => _agency.Value;
        public IClient Client => _client.Value;
        public IMotorcycle Motorcycle => _motorcycle.Value;
        public ICity City => _city.Value;
        public IGarage Garage => _garage.Value;
        public IRent Rent => _rent.Value;
        public IPhone Phone => _phone.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
