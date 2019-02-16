using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string Surname;
        private int Age;
        public Employee()
        {
            Surname = string.Empty;
            Age = 0;
        }

        public Employee(string surname, int age)
        {
            Surname = surname;
            Age = age;
        }

        private string GetAge()
        {
            return Age.ToString();
        }

        public void ChangeSurname(string surname)
        {
            Surname = surname;
        }

        public string GetInfo()
        {
            return "Surname: " + Surname + " Age: ", + Age;
        }
    }
}
