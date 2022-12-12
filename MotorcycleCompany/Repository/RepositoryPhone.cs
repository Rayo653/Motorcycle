using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;


namespace Repository
{
    public class RepositoryPhone : RepositoryBase<Phone>, IPhone
    {
        public RepositoryPhone(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Phone> GetAllPhones(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
