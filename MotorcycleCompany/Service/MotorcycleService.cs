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
    internal sealed class MotorcycleService: IMotorcycleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;


        public MotorcycleService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges)
        {
            try
            {
                var motorcycles = _repository.Motorcycle.GetAllMotorcycles(trackChanges);
                var MotorcycleDto = motorcycles.Select(a => new MotorcycleDto(a.Mat, a.NumBast, a.Color, a.Brand, a.Model)).ToList();
                return motorcycles;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllMotorcycles)} service method {ex}");

                throw;
            }
        }
    }
}
