using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor(string name, int id, bool sweeping) : base(name, id)
        {
            Sweeping = sweeping;
            Salary = 40000;
            
        }

        public override void ViewEmployeeInfo()
        {
            Console.WriteLine($"Janitor: {Name} | Employee ID: {ID} | Employee has been paid: {Paid}");

            if (Sweeping == true)
            {
                Console.WriteLine($"Current Status: {Name} is sweeping.");
            }

            else
            {
                Console.WriteLine($"Current Status: {Name} is not sweeping.");
            }
            Console.WriteLine();
        }
    }
}
