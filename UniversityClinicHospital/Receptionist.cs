using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(bool onPhone) : base("Jimmy", 004, 45000, false)
        {
            OnPhone = onPhone;
        }
    }
}
