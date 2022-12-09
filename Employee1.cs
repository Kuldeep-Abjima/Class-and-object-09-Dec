using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppFirst
{
    public class Employee1
    {
        private string firstName;
        private string lastName;

        private double wage;
        private double hourlyRate;
        private int numberOfHourWork;

        public string FirstName { get
            {
                return firstName;
            }
            set { 
                firstName = value;
               }
        }
        public string LastName { get
            {
                return lastName;
            }
            set { 
                lastName = value; 
            }
        }
        public double Wage { 
            get
            {
                return wage;
            }
            set {
                
                wage = value; 
            }  
            }
        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set

            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }
        public int NumberOfHourWork
        {
            get
            {
                return numberOfHourWork;
            }
            set
            {
                numberOfHourWork = value;
            }
        }
        public Employee1(string first, string last, double rate)
        {
            FirstName= first;
            LastName= last;
            HourlyRate = rate;
        }

        public int performedWork(int hour)
        {
            NumberOfHourWork += hour;
            return NumberOfHourWork;
        }
        public double recieveWage(out int hourWork, ref int bonus)
        {
            Wage = NumberOfHourWork * HourlyRate + bonus;
            Console.WriteLine($"The Wage For {NumberOfHourWork} hours for working is {Wage}");
            NumberOfHourWork = 0;
            hourWork = NumberOfHourWork;
            
            return Wage;
        }

    }
}
