using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinetico.TDD_DataLayerSample.Gateway.Interfaces
{
    public interface IRepository<T>
        where T : IInt32Id
    {
        IList<T> GetAll();
        T GetById(int id);
        void Save(T saveThis);
        void Delete(T deleteThis);
    }
}
