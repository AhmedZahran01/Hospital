using Hospital.DataObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public class AdmissionsService
    {
        private hospitalContext _context;

        public AdmissionsService()
        {
            _context = new();
        }

        public IEnumerable<Admissions> GetAll()
        {
            return _context.Admissions
                .Include(a => a.Patient)
                .OrderBy(a => a.EntryDate)
                .ToList();
        }

        public void Add(Admissions newAdmission)
        {
            _context.Admissions.Add(newAdmission);
            _context.SaveChanges();
        }

        public void Update(Admissions updatedAdmission)
        {
            var existingAdmission = _context.Admissions.Find(updatedAdmission.Id);

            if (existingAdmission != null)
            {
                existingAdmission.EntryDate = updatedAdmission.EntryDate;
                existingAdmission.ExitDate = updatedAdmission.ExitDate;
                existingAdmission.PatientId = updatedAdmission.PatientId;

                _context.SaveChanges();
            }
        }

        public void Delete(int admissionId)
        {
            var admissionToDelete = _context.Admissions.Find(admissionId);

            if (admissionToDelete != null)
            {
                _context.Admissions.Remove(admissionToDelete);
                _context.SaveChanges();
            }
        }

    
    }
}
