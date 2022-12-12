using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IClient
    {
        public RepositoryClient(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(a => a.Name)
        .ToList();
    }
}
