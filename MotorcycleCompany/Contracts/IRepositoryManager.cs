using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAgency Agency { get; }
        IClient Client { get; }
        IPhone Phone { get; }
        ICity City { get; }
        IRent Rent { get; }
        IGarage Garage { get; }
        IMotorcycle Motorcycle { get; }


        void save();
    }

}
