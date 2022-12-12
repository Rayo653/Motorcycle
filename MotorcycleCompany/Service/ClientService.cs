using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObject;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ClientService : IClientService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public ClientService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges)
        {
            try
            {
                var clients = _repository.Client.GetAllClients(trackChanges);
                var ClientDto = clients.Select(a => new ClientDto(a.Name, a.FirstSurname, a.Address, a.PhoneNumber)).ToList();
                return clients;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"something went wrong in the {nameof(GetAllClients)} service method {ex}");
                throw;
            }
        }
    }
}
