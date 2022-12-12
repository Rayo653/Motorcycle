using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class PhoneService : IPhoneService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public PhoneService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<PhoneDto> GetAllPhones(bool trackChanges)
        {
            try
            {
                var phones = _repository.Phone.GetAllPhones(trackChanges);
                //var agenciesDto = agencies.Select(a => new AgencyDto(a.Name, a.Address, a.Population));
                var phonesDto = _mapper.Map<IEnumerable<PhoneDto>>(phones);

                return phonesDto;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllPhones)} service method {ex}");
                throw;
            }
        }
    }
}
