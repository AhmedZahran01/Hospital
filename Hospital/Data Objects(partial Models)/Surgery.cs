using System;
using System.ComponentModel;

namespace Hospital.DataObjects
{
    public partial class Surgery : INotifyPropertyChanged
    {
       
        public int IdSurgery { get; set; }

      
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
        }

        
        private string notes = string.Empty;
        public string Notes
        {
            get { return notes; }
            set
            {
                if (notes != value)
                {
                    notes = value;
                    OnPropertyChanged(nameof(Notes));
                }
            }
        }

       
        private int doctorId;
        public int DoctorId
        {
            get { return doctorId; }
            set
            {
                if (doctorId != value)
                {
                    doctorId = value;
                    OnPropertyChanged(nameof(DoctorId));
                }
            }
        }

       
        private int patientId;
        public int PatientId
        {
            get { return patientId; }
            set
            {
                if (patientId != value)
                {
                    patientId = value;
                    OnPropertyChanged(nameof(PatientId));
                }
            }
        }

       
        private Doctor doctor = null!;
        public virtual Doctor Doctor
        {
            get { return doctor; }
            set
            {
                if (doctor != value)
                {
                    doctor = value;
                    OnPropertyChanged(nameof(Doctor));
                }
            }
        }

       
        private Patient patient = null!;
        public virtual Patient Patient
        {
            get { return patient; }
            set
            {
                if (patient != value)
                {
                    patient = value;
                    OnPropertyChanged(nameof(Patient));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
