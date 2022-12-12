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
    internal sealed class CityService: ICityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;


        public CityService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
           _loggerManager = loggerManager;
        }


        public IEnumerable<City> GetAllCities(bool trackChanges)
        {
            try
            {
                var cities = _repository.City.GetAllCities(trackChanges);
                var CityDto = cities.Select(a => new CityDto(a.Name, a.Province, a.Residents)).ToList();

                return cities;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllCities)} service method {ex}");
                throw;
            }
        }
    }
}
