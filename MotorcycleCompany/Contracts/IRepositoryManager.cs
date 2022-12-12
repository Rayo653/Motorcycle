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
        IGarage Garage { get; }
        ICity City { get; }
        IRent Rent { get; }
        IClient Client { get; }
        IMotorcycle Motorcycle { get; }
        IPhone Phone { get; }
        void Save();
    }
}
