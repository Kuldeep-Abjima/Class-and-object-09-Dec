using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using MyAppFirst;

namespace MyappFirst
{
    public class App
    {
        private static List<Employee1> employee = new List<Employee1>();
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello Welcome To My First App");
            Console.WriteLine("******************************");
            Console.ForegroundColor= ConsoleColor.Green;

            String UserSelect;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Select One Option From Below -: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Create an Employee");
                Console.WriteLine("2. Register Work Hour For Employee");
                Console.WriteLine("3. Pay employee");
                Console.WriteLine("0. Exit");

                UserSelect = Console.ReadLine();
                
                switch (UserSelect)
                {
                
                    case "1": 
                         EmployeeAdd();
                        break;

                    case "2":
                        WorkingHour();
                        break;
                    case "3":
                        Payment();
                        break;

                    default:
                        break;
                }
            }
            while(UserSelect != "0");

            
        }
        private static void EmployeeAdd()
        {
            Console.WriteLine("Enter the First name of an employee : ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name of an employee : ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the Rate Per Hour Work : ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Employee1 addemployee = new Employee1(fname, lname,rate);
            employee.Add(addemployee);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Employee Created");
        }
        private static void WorkingHour()
        {
            Console.WriteLine("Select Employee from below list:");

            if (employee.Count >= 1)
            {
                
                for (int i = 0; i < employee.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}.{employee[i].FirstName}{employee[i].LastName}");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("enter the index id of employee : ");
                int select = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the number of hour work");
                int hour = Convert.ToInt32(Console.ReadLine());

                Employee1 selectedEmployee = employee[select];
                int numOfHourWork = selectedEmployee.performedWork(hour);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{selectedEmployee.FirstName}{selectedEmployee.LastName} hour you worked is {numOfHourWork}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("employee nahi h");
                
                
            }
            
        }
        private static void Payment() {

            if (employee.Count >= 1)
            {
                for (int i = 0; i < employee.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}.{employee[i].FirstName}{employee[i].LastName}");
                }
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Enter the index id of employee");
                int select = Convert.ToInt32(Console.ReadLine());
                Employee1 selectedEmployee = employee[select];
                int hourWorked;
                Console.WriteLine("You want to give bonus to this employee? \n yes or no");
                string get = Console.ReadLine();
                if (get == "yes" || get == "Yes")
                {
                    Console.WriteLine("enter the bonus amount : ");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    double payment = selectedEmployee.recieveWage(out hourWorked, ref bonus);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{selectedEmployee.FirstName}{selectedEmployee.LastName} your bonus is {bonus} & Payemnt is {payment} ");
                }
                else
                {
                    int bonus = 0;
                    double payment = selectedEmployee.recieveWage(out hourWorked, ref bonus);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{selectedEmployee.FirstName}{selectedEmployee.LastName} hour you Payemnt is {payment}");
                }
                }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("employee nahi h");
            }

        }
            
        
    }
}