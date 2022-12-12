using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IClient
    {
        public RepositoryClient(RepositoryContext context)
            : base(context)
        {
        }

        public IEnumerable<Client> GetAllClients(bool trackchanges) =>
           FindAll(trackchanges)
           .OrderBy(a => a.Name)
           .ToList();
    }
}
