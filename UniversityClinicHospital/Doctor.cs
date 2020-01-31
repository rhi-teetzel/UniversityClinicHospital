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
       



    }
}
