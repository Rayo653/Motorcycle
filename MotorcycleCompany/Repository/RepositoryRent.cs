using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
namespace Repository
{
    public class RepositoryRent : RepositoryBase<Rent>, IRent
    {
        public RepositoryRent(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Rent> GetAllRents(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
