using Hospital.DataObjects;
using Hospital.Scaffold;
using Microsoft.EntityFrameworkCore;
using Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Om_El_Masryeen_Hospital.Repositories.Repo_Classes
{
    internal class AdmissionsRepo : GenericRepository<Admissions, int>, IAdmissionsRepo
    {
        public AdmissionsRepo(hospitalContext context) : base(context)
        {

        }
        
        //public IEnumerable<Admissions> GetAll()
        //{
        //    return hospitalContextss.Admissions
        //        .Include(a => a.Patient)
        //        .OrderBy(a => a.EntryDate)
        //        .ToList();
        //}
    }
}
