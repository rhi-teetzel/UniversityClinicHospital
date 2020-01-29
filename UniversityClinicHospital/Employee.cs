using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        //Constructors

        public Employee()
        {

        }
        public Employee(string name, int id, int salary, bool paid)
        {
            Name = name;
            ID = id;
            Salary = salary;
            Paid = paid;
        }



    }
}
