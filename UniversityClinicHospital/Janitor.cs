using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor(string name, int id, bool sweeping) : base(name, id)
        {
            Sweeping = sweeping;
            Salary = 40000;
            
        }
    }
}
