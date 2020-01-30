using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        //create List above objects
        //list as a property
        public List<Employee> employeesList = new List<Employee>();

        //Properties
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        //Constructors

        public Employee()
        {

        }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
            Paid = false;
        }

        //methods
        public void ViewAllEmployees()
        {
            foreach(Employee employee in employeesList)
            {
                employee.ViewEmployeeInfo();
            }
        }
        public virtual void ViewEmployeeInfo()
        {
        }
        public void PayAllEmployees()
        {
            foreach(Employee employee in employeesList)
            {
                if (Paid == false)
                {
                    employee.Paid = true;
                    Console.WriteLine(employee.Name + " has now been PAID.");
                }
                else
                {
                    Console.WriteLine(employee.Name + " HAS ALREADY BEEN PAID THIS SESSION.");
                }
                
            }
            
        }


        
    }
}
