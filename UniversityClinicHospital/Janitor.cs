using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor(bool sweeping) : base("Fran", 003, 40000, false)
        {
            sweeping = Sweeping;
        }
    }
}
