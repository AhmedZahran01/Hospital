using System;
using System.ComponentModel;

namespace Hospital.DataObjects
{
    public partial class Appointments : INotifyPropertyChanged //ميعاد  Appointment
    {
        public int Id { get; set; }


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
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
