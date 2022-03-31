using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
   abstract class Person
    {
        private string _Name;
        public string Name { get; set; }

        private string _Surname;
        public string Surname { get; set; }

        private int _Age;
        public int Age { get; set; }
        public Person(string name, string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = Age;
        }
    }
}
