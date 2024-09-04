using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces
{
    public interface IGenericRepository<T, v> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(v id);

        int Insert(T customer);

        void Update(T customer);

        int Delete(v customerid);

    }
}