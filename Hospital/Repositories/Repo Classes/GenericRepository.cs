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
        private protected readonly hospitalContext hospitalContextss;
        public GenericRepository(hospitalContext c1ontex10)
        {
            hospitalContextss = c1ontex10;
        }

        public IEnumerable<T> GetAll()
            => (from a in hospitalContextss.Set<T>() select a).ToList();


        public T GetById(V id)
          => hospitalContextss.Find<T>(id);


        public int Insert(T order)
        {
            hospitalContextss.Add(order);
            return hospitalContextss.SaveChanges();
        }

        public void Update(T order)
        {
            hospitalContextss.Update(order);
            hospitalContextss.SaveChanges();
        }

        public int Delete(V orderid)
        {
            hospitalContextss.Remove(orderid);
            return hospitalContextss.SaveChanges();
        }

    }
}
