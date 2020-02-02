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

            //Populate all emplyee Lists
            employee.employeesList.Add(doctor);
            employee.employeesList.Add(nurse);
            employee.employeesList.Add(janitor);
            employee.employeesList.Add(receptionist);


            //create menu
            string menuChoice = "";
            string medicalMenuChoice = "";
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
                        Console.WriteLine("VIEW PATIENT STATUS\n");
                        patient.ViewPatientStatus();
                        break;
                
                    case "4":
                        Console.WriteLine("CARE FOR PATIENT\n");
                        Console.WriteLine("Please Select a Medical Employee:");
                        Console.WriteLine($"1. {doctor.Name} ");
                        Console.WriteLine($"2. Nurse {nurse.Name}");
                        medicalMenuChoice = Console.ReadLine();

                        if (medicalMenuChoice == "1")
                        {
                            doctor.CareForPatients(patient);
                        }

                        else if (medicalMenuChoice == "2")
                        {
                            nurse.CareForPatients(patient);
                        }
                        else
                        {
                            break;
                        }
                        break;

                    case "5":
                        Console.WriteLine("DRAW BLOOD\n");
                        Console.WriteLine("Please Select a Medical Employee:");
                        Console.WriteLine($"1. {doctor.Name} ");
                        Console.WriteLine($"2. Nurse {nurse.Name}");
                        medicalMenuChoice = Console.ReadLine();

                        if (medicalMenuChoice == "1")
                        {
                            doctor.DrawBlood(patient);
                        }

                        else if (medicalMenuChoice == "2")
                        {
                            nurse.DrawBlood(patient);
                        }
                        else
                        {
                            break;
                        }
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
