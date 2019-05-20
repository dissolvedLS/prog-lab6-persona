using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    class Abiturient : Persona
    {
        protected string surname;
        protected string birthDateStr;
        protected string faculty;

        public Abiturient(string a, string b, string c)
        {
            surname = a;
            birthDateStr = b;
            faculty = c;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия:        " + surname);
            Console.WriteLine("Дата рождения:  " + birthDateStr);
            Console.WriteLine("Факультет:      " + faculty);
        }
        public override double Age()
        {
            string[] split = birthDateStr.Split(new Char[] { ' ', ',', '.', ':', '/', '\t' });
            int bYear = int.Parse(split[2]);
            int bMonth = int.Parse(split[1]);
            int bDay = int.Parse(split[0]);
            DateTime bDate = new DateTime(bYear, bMonth, bDay);

            int age = DateTime.Now.Year - bDate.Year;
            if (DateTime.Now.Month < bDate.Month || (DateTime.Now.Month == bDate.Month && DateTime.Now.Day < bDate.Day))
                age--;

            return age;
        }
    }
}
