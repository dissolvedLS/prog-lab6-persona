using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    class Vykladach : Abiturient
    {
        protected string post;
        protected int stazh;
        public Vykladach(string a, string b, string c, string e, int f) : base(a, b, c)
        {
            post = e;
            stazh = f;
        }
        public override void Show()
        {
            Console.WriteLine("Фамилия:        " + surname);
            Console.WriteLine("Дата рождения:  " + birthDateStr);
            Console.WriteLine("Факультет:      " + faculty);
            Console.WriteLine("Должность:      " + post);
            Console.WriteLine("Стаж:           " + stazh + " лет");
        }
    }
}
