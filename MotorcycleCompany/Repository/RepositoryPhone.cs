using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryPhone : RepositoryBase<Phone>, IPhone
    {
        public RepositoryPhone(RepositoryContext context) 
            : base(context)
        {
        }

        public IEnumerable<Phone> GetAllPhones(bool trackChanges) =>
    FindAll(trackChanges)
    .OrderBy(a => a.PhoneNumber)
    .ToList();
    }
}
