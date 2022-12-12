using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class AgencyService : IAgencyService 
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public AgencyService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Agency> GetAllAgencies(bool trackChanges)
        {
            try
            {
                var agencies = _repository.Agency.GetAllAgencies(trackChanges);
                var AgenciesDto = agencies.Select(a => new AgencyDto(a.Name, a.Address, a.Population)).ToList();

                return agencies;
            }
            catch (Exception ex)
            {

                _loggerManager.LogError($"something went wrong in the {nameof(GetAllAgencies)} service method {ex}");
                throw;

            }
        }
    }
}
