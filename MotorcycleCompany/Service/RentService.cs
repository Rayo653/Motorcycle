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
    internal sealed class RentService : IRentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public RentService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<RentDto> GetAllRents(bool trackChanges)
        {


            var rent = _repository.Rent.GetAllRents(trackChanges);

            var rentDto = _mapper.Map<IEnumerable<RentDto>>(rent);

            return rentDto;


        }
    }
}
