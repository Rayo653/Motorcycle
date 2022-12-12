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
    internal sealed class RentService : IRentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public RentService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Rent> GetAllRents(bool trackChanges)
        {
            try
            {
                var rents = _repository.Rent.GetAllRents(trackChanges);
                var RentDto = rents.Select(a => new RentDto(a.Mat, a.NameAgency, a.DNIClient)).ToList();
                return rents;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllRents)} service method {ex}");

                throw;
            }
        }
    }
}
