﻿using System;
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
        

        //method
        public void ViewPatientStatus()
        {
            Console.WriteLine($"\nPatient: {Name} | Blood Level: {BloodLevel} | Health Level: {HealthLevel}\n");

        }
        
        


    }
}
