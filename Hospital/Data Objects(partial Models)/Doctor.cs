using System;
using System.Collections.Generic;

namespace Hospital.DataObjects
{
    public partial class Doctor : Person
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointments>();
            Records = new HashSet<Record>();
            Surgeries = new HashSet<Surgery>();
        }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Surgery> Surgeries { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Contact})";
        }
    }
}
