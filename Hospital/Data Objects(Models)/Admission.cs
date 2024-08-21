using System;
using System.ComponentModel;

namespace Hospital.DataObjects
{
    public partial class Admission : INotifyPropertyChanged  // Admission  قبول    ,
    {
       
        public int Id { get; set; }

       
        private DateTime entryDate;
        public DateTime EntryDate
        {
            get { return entryDate; }
            set
            {
                if (entryDate != value)
                {
                    entryDate = value;
                    OnPropertyChanged(nameof(EntryDate));
                }
            }
        }

      

        private DateTime exitDate; //تاريخ الخروج
        public DateTime ExitDate
        {
            get { return exitDate; }
            set
            {
                if (exitDate != value)
                {
                    exitDate = value;
                    OnPropertyChanged(nameof(ExitDate));
                }
            }
        }



        private int _patientId;
        public int PatientId
        {
            get { return _patientId; }
            set
            {
                if (_patientId != value)
                {
                    _patientId = value;
                    OnPropertyChanged(nameof(PatientId));
                }
            }
        }

        
        
        private Patient _patient = null!;
        public virtual Patient Patient
        {
            get { return _patient; }
            set
            {
                if (_patient != value)
                {
                    _patient = value;
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
