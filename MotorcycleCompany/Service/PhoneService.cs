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
    internal sealed class PhoneService : IPhoneService
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public PhoneService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Phone> GetAllPhones(bool trackChanges)
        {
            try
            {
                var phones = _repository.Phone.GetAllPhones(trackChanges);
                var PhonesDto = phones.Select(a => new PhoneDto(a.NameAgency, a.PhoneNumber)).ToList();
                return phones;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllPhones)} service method {ex}");

                throw;
            }
        }
    }
}
