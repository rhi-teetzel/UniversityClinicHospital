using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //create List above objects
            //create employee objects:
            Doctor doctor = new Doctor("Dr. Sally", 001, "General Surgeon");
            Nurse nurse = new Nurse("Jack", 002, 1);
            Patient patient = new Patient("Bob Builder");

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

                switch (menuChoice)
                {
                    case "1":
                        break;

                    case "2":
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
