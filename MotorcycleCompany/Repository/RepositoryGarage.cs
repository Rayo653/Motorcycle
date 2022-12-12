using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class RepositoryGarage : RepositoryBase<Garage>, IGarage
    {
        public RepositoryGarage(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Garage> GetAllGarages(bool trackchanges) =>
           FindAll(trackchanges)
           .OrderBy(a => a.Name)
           .ToList();
    }
}
