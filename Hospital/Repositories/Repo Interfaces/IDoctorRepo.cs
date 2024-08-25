using Hospital.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces
{
    public interface IDoctorRepo:IGenericRepository<Doctor, int>
    {
        Task<Doctor> GetByIdAsync(int id);
    }
}
