using Hospital.DataObjects;
using Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Om_El_Masryeen_Hospital.Repositories.Repo_Classes
{
    public class GenericRepository<T, V> : IGenericRepository<T, V> where T : class
    {
        private protected readonly hospitalContext dokkanah2;
        public GenericRepository(hospitalContext c1ontex10)
        {
            dokkanah2 = c1ontex10;
        }

        public IEnumerable<T> GetAll()
            => (from a in dokkanah2.Set<T>() select a).ToList();


        public T GetById(V id)
          => dokkanah2.Find<T>(id);


        public int Insert(T order)
        {
            dokkanah2.Add(order);
            return dokkanah2.SaveChanges();
        }

        public int Update(T order)
        {
            dokkanah2.Update(order);
            return dokkanah2.SaveChanges();
        }

        public int Delete(T order)
        {
            dokkanah2.Remove(order);
            return dokkanah2.SaveChanges();
        }

    }
}
