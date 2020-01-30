using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string name, int id, bool onPhone) : base(name, id)
        {
            OnPhone = onPhone;
            Salary = 45000;
        }


        public override void ViewEmployeeInfo()
        {
            Console.WriteLine($"Receptionist: {Name} | Employee ID: {ID} | Employee has been paid: {Paid}");

            if (OnPhone == true)
            {
                Console.WriteLine($"Current Status: {Name} is on the phone!");
            }

            else
            {
                Console.WriteLine($"Current Status: {Name} is not on the phone.");


            }
            Console.WriteLine();       
        }
    }
}
