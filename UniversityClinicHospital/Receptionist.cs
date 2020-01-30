using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string name, int id, bool onPhone) : base(name, id)
        {
            OnPhone = onPhone;
            Salary = 45000;
        }
    }
}
