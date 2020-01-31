using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //create employee objects:
            Employee employee = new Employee();
            Doctor doctor = new Doctor("Dr. Sally", 1001, "General Surgeon");
            Nurse nurse = new Nurse("Jack", 1002, 1);            
            Janitor janitor = new Janitor("Fran", 1003, true);
            Receptionist receptionist = new Receptionist("Jimmy", 1004, false);
            Patient patient = new Patient("Bob Builder");

            //Populate Lists
            employee.employeesList.Add(doctor);
            employee.employeesList.Add(nurse);
            employee.employeesList.Add(janitor);
            employee.employeesList.Add(receptionist);

            employee.medicalStaff.Add(doctor);
            employee.medicalStaff.Add(nurse);


            //create menu
            string menuChoice = "";
            bool userActive = true;

            while (userActive)
            {
                Console.WriteLine("HOSPITAL MENU");
                Console.WriteLine("1. View Employees");
                Console.WriteLine("2. Pay All Employees");
                Console.WriteLine("3. View Patient Status");
                Console.WriteLine("4. Care For Patients");
                Console.WriteLine("5. Draw Blood");
                Console.WriteLine("6. Exit");
                menuChoice = Console.ReadLine();
                Console.Clear();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("EMPLOYEE LIST");
                        employee.ViewAllEmployees(); 
                        break;

                    case "2":
                        Console.WriteLine("ACCOUNTS PAYABLE\n");
                        employee.PayAllEmployees();
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        userActive = false;
                        break;
                    default:
                        break;



                }
                Console.ReadLine();
            }
            
        }
       
    }
}
