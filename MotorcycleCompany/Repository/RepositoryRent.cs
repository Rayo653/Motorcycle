using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryRent : RepositoryBase<Rent>, IRent
    {
        public RepositoryRent(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Rent> GetAllRents(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(a => a.DateS)
        .ToList();
    }
}
