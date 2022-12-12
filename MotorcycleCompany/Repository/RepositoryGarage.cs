using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryGarage : RepositoryBase<Garage>, IGarage
    {
        public RepositoryGarage(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Garage> GetAllGarages(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(a => a.Name)
        .ToList();
    }
}
