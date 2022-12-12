using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
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
        private readonly IMapper _mapper;

        public AgencyService(IRepositoryManager repository,
            ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<AgencyDto> GetAllAgency(bool trackChanges)
        {
            
            
                var agencies = _repository.Agency.GetAllAgencies(trackChanges);
                //var agenciesDto = agencies.Select(a => new AgencyDto(a.Name, a.Address, a.Population));
                var agenciesDto = _mapper.Map<IEnumerable<AgencyDto>>(agencies);

                return agenciesDto;
            

        }
    }



}
