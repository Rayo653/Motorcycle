using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryMotorcycle : RepositoryBase<Motorcycle>, IMotorcycle
    {
        public RepositoryMotorcycle(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(a => a.Mat)
        .ToList();
    }
}
