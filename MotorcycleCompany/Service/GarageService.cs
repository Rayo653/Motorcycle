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
    internal sealed class GarageService : IGarageService
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public GarageService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Garage> GetAllGarages(bool trackChanges)
        {
            try
            {
                var garages = _repository.Garage.GetAllGarages(trackChanges);
                var GarageDto = garages.Select(a => new GarageDto(a.Name, a.Address)).ToList();

                return garages;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllGarages)} service method {ex}");

                throw;
            }
        }
    }
}
