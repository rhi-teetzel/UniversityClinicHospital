using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        Patient patient = new Patient("Bob Builder");
        
        


        //properties
        public string Specialty { get; set; } 
        

        //constructors
        public Doctor(string name, int id, string specialty) : base(name, id)
        {
            Specialty = specialty;
            Salary = 90000;
        }
        public override void ViewEmployeeInfo()
        {
            Console.WriteLine($"\nDoctor: {Name} | Employee ID: {ID} | Specialty: {Specialty} | Employee Has Been Paid: {Paid}");
            Console.WriteLine();
        }

        //methods

        public override void CareForPatients()
        {
            patient.HealthLevel += 20;
            Console.WriteLine($" \n{Name} has cared for {patient.Name} and his health level has increased to {patient.HealthLevel}");
        }

        public override void DrawBlood()
        {
            patient.BloodLevel -= 20;
            Console.WriteLine($" \n{Name} has drawn blood from {patient.Name} and his blood level has decreased to {patient.BloodLevel}");
        }


    }
}
