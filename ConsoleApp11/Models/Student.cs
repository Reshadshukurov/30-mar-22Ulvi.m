using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    class Student : Person
    {
        public int IQRank;
        public int LanguageRank;
        public  int ExamResult(int examresult)
        {
            if (examresult < 120)
            {
                Console.WriteLine("sinifde qaldin bala");
            }
           
                return examresult;
        }
        public Student(string name, string surname, int age, int iQRank, int languageRank):base(name,surname,age)
        {
          
            IQRank = iQRank;
            LanguageRank = languageRank;

        }
        public int age
        {
            get { return age; }
            set
            {
                if (age>6&&age<20)
                {
                    age = value;
                }
            }
        }
    }
}
