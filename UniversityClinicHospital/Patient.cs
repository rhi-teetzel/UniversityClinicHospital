using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
   public class Patient
    {
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }
        public string Name { get; set; } 

        public Patient(string name)
        {
            Name = name;
            BloodLevel = 100;
            HealthLevel = 50;
        }
        public Patient()
        {

        }

        //method
        public void ViewPatientStatus()
        {
            Console.WriteLine($"\nPatiet: {Name} | Blood Level: {BloodLevel} | Health Level: {HealthLevel}\n");

        }
        
        


    }
}
