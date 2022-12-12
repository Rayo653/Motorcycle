using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryCity : RepositoryBase<City>, ICity
    {
        public RepositoryCity(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<City> GetAllCities(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(a => a.Name)
        .ToList();
    }
}
