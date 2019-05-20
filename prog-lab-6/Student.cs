using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    class Student : Abiturient
    {
        protected int yearOfStudy;
        public Student(string a, string b, string c, int d) : base (a, b, c)
        {
            yearOfStudy = d;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия:        " + surname);
            Console.WriteLine("Дата рождения:  " + birthDateStr);
            Console.WriteLine("Факультет:      " + faculty);
            Console.WriteLine("Курс:           " + yearOfStudy);
        }
    }
}
