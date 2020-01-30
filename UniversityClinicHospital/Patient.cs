using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
   public class Patient
    {
        public int BloodLevel { get; set; } = 20;
        public int HealthLevel { get; set; } = 10;
        public string Name { get; set; } 

        public Patient(string name)
        {
            Name = name;
            BloodLevel = 100;
            HealthLevel = 50;
        }
        
        


    }
}
