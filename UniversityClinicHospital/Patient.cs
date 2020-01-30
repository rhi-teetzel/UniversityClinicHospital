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

        public Patient(string name, int bloodLevel, int healthLevel)
        {
            Name = name;
            BloodLevel = bloodLevel;
            HealthLevel = healthLevel;
        }
        Patient firstPatient = new Patient("Bob Builder", 100, 50);
        Patient secondPatient = new Patient("Dora Explorer", 100, 25);


    }
}
