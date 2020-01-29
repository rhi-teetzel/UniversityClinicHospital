using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        //properties
        public string Specialty { get; set; } 
        

        //constructors
        public Doctor(string specialty) : base("Dr. Sally", 001, 90000, false)
        {
            specialty = "Heart";
            Specialty = specialty;
            
        }

        

    }
}
