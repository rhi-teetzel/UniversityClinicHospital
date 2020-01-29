using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        //Properties
        public int NumOfPatients { get; set; }

        //Constructors
        public Nurse(int numOfPatients) : base("Nurse Jack", 002, 50000, false)
        {
            NumOfPatients = numOfPatients;
        }

    }
}
