using Hospital.DataObjects;
using Microsoft.EntityFrameworkCore;
using Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Om_El_Masryeen_Hospital.Repositories.Repo_Classes
{
    internal class DoctorRepo : GenericRepository<Doctor, int> , IDoctorRepo 
    {
        public DoctorRepo(hospitalContext context):base(context)
        {
            
        }

        public async Task<Doctor>   GetByIdAsync(int id)
        {
            return await hospitalContextss.Doctors.
                FirstOrDefaultAsync(x => x.Id == id);
        }

        
    }
}
