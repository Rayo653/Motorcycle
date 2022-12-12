using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;


namespace Repository
{
    public class RepositoryCity : RepositoryBase<City>, ICity
    {
        public RepositoryCity(RepositoryContext context) : base(context)
        {
        }
        public IEnumerable<City> GetAllCities(bool trackchanges) =>
           FindAll(trackchanges)
           .OrderBy(a => a.Name)
           .ToList();
    }
}
