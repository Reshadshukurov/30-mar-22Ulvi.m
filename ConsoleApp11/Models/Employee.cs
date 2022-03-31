using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    class Employee:Person
    {

        public int SalaryOfHour
        {
            get { return SalaryOfHour; }
            set
            {
                if (value>0)
                {
                    SalaryOfHour = value;
                }
            }
        }
        public int WorkingHour;
        public void CalculateSalary() 
        {
            if (SalaryOfHour*WorkingHour>250)
            {
                Console.WriteLine(SalaryOfHour * WorkingHour);
            }
        
        }
        public int age
        {
            get { return age; }
            set
            {
                if (age <18)
                {
                    age = value;
                }
            }
        }
        public Employee(string name, string surname, int age, int salaryOfHour, int workingHour):base(name,surname,age)
        {
          
            SalaryOfHour = salaryOfHour;
            WorkingHour = workingHour;

        }
    }
}
