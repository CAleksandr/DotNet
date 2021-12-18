using System;
using System.Text.RegularExpressions;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать! Введите имя студента: ");
            string st_name = Console.ReadLine();
            string pattern = "[A-Za-zА-Яа-яЁё]+";
            if (!Regex.IsMatch(st_name, pattern))
            {
                Console.WriteLine("Имя введено некорректно!");
            }

            Console.Write("Введите фамилию студента: ");
            string st_surname = Console.ReadLine();
            if (!Regex.IsMatch(st_surname, pattern))
            {
                Console.WriteLine("Фамилия введена некорректно!");
            }

            Console.Write("Введите отчество студента: ");
            string st_patr = Console.ReadLine();
            if (!Regex.IsMatch(st_patr, pattern))
            {
                Console.WriteLine("Отчество введено некорректно!");
            }

            Console.Write("Введите индекс группы студента: ");
            char st_ind = Convert.ToChar(Console.ReadLine());
            pattern = "[A-ZА-Я]";
            if (!Regex.IsMatch(st_ind.ToString(), pattern))
            {
                Console.WriteLine("Введен недопустимый индекс!");
            }

            Console.Write("Введите факультет студента: ");
            string st_facul = Console.ReadLine();
            pattern = "[A-Za-zА-Яа-яЁё]+";
            if (!Regex.IsMatch(st_facul, pattern))
            {
                Console.WriteLine("Факультет введен некорректно!");
            }

            Console.Write("Введите специальность студента: ");
            string st_spec = Console.ReadLine();
            if (!Regex.IsMatch(st_spec, pattern))
            {
                Console.WriteLine("Специальность введена некорректно!");
            }

            Console.Write("Введите день рождения студента: ");
            int st_day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц рождения студента: ");
            int st_moun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год рождения студента: ");
            int st_year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день поступления студента: ");
            int st_aday = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц поступления студента: ");
            int st_amoun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год поступления студента: ");
            int st_ayear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите успеваемость студента: ");
            byte st_perf = Convert.ToByte(Console.ReadLine());

            Student st0 = new Student(st_name, st_surname, st_patr, st_ind, st_facul, st_spec, new DateTime(st_year, st_moun, st_day), new DateTime(st_ayear, st_amoun, st_aday), st_perf);

            st0.GetInfo();

            Console.WriteLine("Работа с массивом-----------------------------------------------");

            Student st1 = new Student("Ivan", "Ivanov", "Ivanovich", 'A', "CIT", "Comp Logic", new DateTime(2000, 11, 19), new DateTime(2017, 7, 23), 88);

            var st2 = new Student("Petr", "Petrov", "Petrovich", 'B', "CIT", "Comp Logic", new DateTime(2002, 10, 16), new DateTime(2020, 8, 21), 57);

            var stds = new Student[] { st1, st2 };

            foreach (var stud in stds)
            {
                stud.GetInfo();
            }
        }
    }
}
