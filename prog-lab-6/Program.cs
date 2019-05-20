using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Абитуриент------------");
            Abiturient a = new Abiturient("Мальцев", "26 08 2000", "ЭлИТ");
            a.Show();
            Console.WriteLine("Возраст:        " + a.Age());
            Console.WriteLine();


            Console.WriteLine("-------------Студент----------------"); 
            Student b = new Student("Скороход", "17 04 2000", "ЭлИТ", 2);
            b.Show();
            Console.WriteLine("Возраст:        " + b.Age());
            Console.WriteLine();


            Console.WriteLine("-------------Преподаватель-----------"); 
            Vykladach с = new Vykladach("Шовкопляс", "17 10 1975", "ЭлИТ", "Доктор Математических Наук", 25);
            с.Show();
            Console.WriteLine("Возраст:        " + с.Age());
            Console.WriteLine();
        }
    }
}