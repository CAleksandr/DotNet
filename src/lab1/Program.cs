using System;
using System.Text.RegularExpressions;

namespace lab1
{
    class Student
    {
        //Поля
        private string name;

        private string surname;

        private string patronymic;

        DateTime DOB;

        DateTime DOA;

        private char groupIndex;

        private string faculty;

        private string speciality;

        private byte performance;
        //Свойства
        public DateTime GetDateOfAdmission()
        {
            return DOA;
        }

        public void SetDateOfAdmission(int year, int month, int day)
        {
            DateCheck(year, month, day);
            DOA = new DateTime(year, month, day);
        }

        public DateTime GetDateOfBrth()
        {
            return DOB;
        }
        public void SetDateOfBrth(int year, int month, int day)
        {
            DateCheck(year, month, day);
            DOB = new DateTime(year, month, day);
        }
        public byte Perf
        {
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Успеваемость не может быть выше 100 и ниже 0 процентов!");
                }
                else
                {
                    performance = value;
                }
            }
            get { return performance; }
        }
        public string spec
        {
            get
            {
                return speciality;
            }

            set
            {
                speciality = value;
            }
        }
        public string facul
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }
        public char GIndex
        {
            get
            {
                return groupIndex;
            }

            set
            {
                groupIndex = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set
            {
                patronymic = value;
            }
        }

        public string surName
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Студент " + Name + " " + surName + " " + Patronymic + " группы " + GIndex + " факультета " + facul + " специальности " + spec + ", " + GetDateOfBrth() + " даты рождения, " + GetDateOfAdmission() + " даты поступления имеет успеваемость " + Perf + "%");
        }

        public Student(string nm, string srnm, string patr, char Gin, string fcl, string spc, DateTime Birth, DateTime Adm, byte persent)
        {
            DateCheck(Birth.Year, Birth.Month, Birth.Day);
            DateCheck(Adm.Year, Adm.Month, Adm.Day);
            name = nm;
            surname = srnm;
            patronymic = patr;
            groupIndex = Gin;
            faculty = fcl;
            speciality = spc;
            DOB = Birth;
            DOA = Adm;
            performance = persent;
        }


        public void DateCheck(int year, int month, int day)
        {
            var currentYear = DateTime.Now.Year;
            if (year > currentYear)
            {
                Console.WriteLine("Год введен некорректно!");
            }
            if(month > 12 && month <= 0)
            {
                Console.WriteLine("Месяц введен некорректно!");
            }
            if(day > 31 && day <= 0)
            {
                Console.WriteLine("День введен некорректно!");
            }
        }
    }
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

            Student st2 = new Student("Petr", "Petrov", "Petrovich", 'B', "CIT", "Comp Logic", new DateTime(2002, 10, 16), new DateTime(2020, 8, 21), 57);

            Student[] stds = new Student[] { st1, st2 };

            foreach (var stud in stds)
            {
                stud.GetInfo();
            }
        }
    }
}
