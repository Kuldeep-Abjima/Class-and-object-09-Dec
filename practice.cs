using System;
using Practice1.HR;

namespace Practice1
{
    public class practice{
        static void Main (string[] args)
        {
            Console.WriteLine("Creating the employee");
            Console.WriteLine("--------------------\n");
            
            Employee kuldeep = new Employee("kuldeep", "Singh", "ksingh2243@gmail.com", new DateTime(2001, 12, 04), EmployeeType.Research, 25);
            Employee Test = kuldeep;

            kuldeep.DisplayEmployeeDetails();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.RecievedWage();
            Console.ReadLine();
        }

    }
}