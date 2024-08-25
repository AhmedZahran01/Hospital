using Hospital.Scaffold;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Hospital.DataObjects
{ 
   
    public partial class Patient : INotifyPropertyChanged
    {

        public Patient()
        {
            Admissions = new HashSet<Admission>();
            Appointments = new HashSet<Appointments>();
            Records = new HashSet<Record>();
            Surgeries = new HashSet<Surgery>();
        }

       
        public int Id { get; set; }


        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }


        private string surname = string.Empty;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }
        }

       
        
        private string contact = string.Empty;
        public string Contact
        {
            get { return contact; }
            set
            {
                if (contact != value)
                {
                    contact = value;
                    OnPropertyChanged(nameof(Contact));
                }
            }
        }



        private string address = string.Empty;
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged(nameof(Address));
                }
            }
        }

         
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged(nameof(BirthDate));
                }
            }
        }


        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Surgery> Surgeries { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        
        public override string ToString()
        {
            return $"{Name} {Surname} ({Contact})";
        }
   
    }
}
