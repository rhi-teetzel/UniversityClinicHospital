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

        //Methods
        public override void ViewEmployeeInfo()
        {
            Console.WriteLine($"Nurse: {Name} | Employee ID: {ID} | Current Number of Patients: {NumOfPatients} | Employee Has Been Paid: {Paid}");
            Console.WriteLine();
        }

        public override void CareForPatients(Patient patient)
        {
            patient.HealthLevel += 30;
            Console.WriteLine($" \nNurse {Name} has cared for {patient.Name} and his health level has increased to {patient.HealthLevel}");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 10;
            Console.WriteLine($" \nNurse {Name} has drawn blood for {patient.Name} and his blood level has decreased to {patient.BloodLevel}");
        }
    }
}
