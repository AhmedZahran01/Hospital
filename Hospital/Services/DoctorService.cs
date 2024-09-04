using Hospital.DataObjects;
using Microsoft.EntityFrameworkCore;
using Om_El_Masryeen_Hospital.Repositories.Repo_Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public class DoctorService
    {
      
        private readonly IDoctorRepo doctor;

        public DoctorService()
        {
            
        }
        public DoctorService(IDoctorRepo doctor )
        {
            this.doctor = doctor;
        }

        public IEnumerable<Doctor> GetAll()
        {
            return   doctor.GetAll();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await doctor.GetByIdAsync(id);
        }

        public Doctor GetById(int id)
        {
            return  doctor.GetById(id);
        }

        public async Task<bool> Update(Doctor doctoraws)
        {
            if (doctoraws == null)
            {
                return false;
            }

            try
            {
                doctor.Update(doctoraws);
                return true;
            } 
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }
        }

        public void Delete(int id)
        {
            var toDelete = doctor.GetById(id);

            if (toDelete != null)
            {
                doctor.Delete(id);
            }
        }
    }
}
