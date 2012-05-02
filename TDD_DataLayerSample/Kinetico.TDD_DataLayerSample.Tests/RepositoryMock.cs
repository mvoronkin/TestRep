using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinetico.TDD_DataLayerSample.Gateway.Interfaces;

namespace Kinetico.TDD_DataLayerSample.Tests
{
    // simple key value store of database entity items
    public class RepositoryMock<T> : IRepository<T> where T : IInt32Id
    {
        private int currentIdValue = 0;

        public RepositoryMock()
        {
            Items = new List<T>();
        }

        protected List<T> Items { get; set; }

        public void Save(T saveThis)
        {
            if (saveThis == null)
            {
                throw new ArgumentNullException("saveThis", "Argument cannot be null.");
            }

            if (saveThis.Id == 0)
            {
                saveThis.Id = ++currentIdValue;
            }

            if (Items.Contains(saveThis) == false)
            {
                Items.Add(saveThis);
            }
        }

        public T GetById(int id)
        {
            return (from item in Items
                    where item.Id == id
                    select item).FirstOrDefault();
        }

        public IList<T> GetAll()
        {
            return Items;
        }

        public void Delete(T saveThis)
        {
            Items.Remove(saveThis);
        }
    }
}
