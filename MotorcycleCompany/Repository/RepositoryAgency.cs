using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryAgency : RepositoryBase<Agency>, IAgency
    {
        public RepositoryAgency(RepositoryContext context) 
            : base(context)
        {
        }

        public IEnumerable<Agency> GetAllAgencies(bool trackchanges) =>
            FindAll(trackchanges)
            .OrderBy(a => a.Name)
            .ToList();
    }
}
