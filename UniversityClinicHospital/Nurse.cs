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
        public Nurse(string name, int id, int numOfPatients) : base(name, id)
        {
            
            NumOfPatients = numOfPatients;
            Salary = 50000;
        }

    }
}
