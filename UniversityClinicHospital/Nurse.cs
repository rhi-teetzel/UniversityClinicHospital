using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        Patient patient = new Patient();

        //Properties
        public int NumOfPatients { get; set; }

        //Constructors
        public Nurse(string name, int id, int numOfPatients) : base(name, id)
        {
            
            NumOfPatients = numOfPatients;
            Salary = 50000;
        }

        //Methods
        public override void ViewEmployeeInfo()
        {
            Console.WriteLine($"Nurse: {Name} | Employee ID: {ID} | Current Number of Patients: {NumOfPatients} | Employee Has Been Paid: {Paid}");
            Console.WriteLine();
        }

        
    }
}
