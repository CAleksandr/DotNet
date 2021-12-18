using System;

namespace lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var st1 = new Student("Ivan", "Ivanov", "Ivanovich", 'A', "CIT", "Comp Logic", new DateTime(2000, 11, 19), new DateTime(2017, 7, 23), 88);
            var st2 = new Student("Petr", "Petrov", "Petrovich", 'B', "CIT", "Comp Logic", new DateTime(2002, 10, 16), new DateTime(2020, 8, 21), 57);
            Collection arr = new(st1);
            arr.AddStudent(st2);
            arr.Print();

            Console.WriteLine("Доступ к элементу-----------------------------------------------");
            var st3 = new Student("Oleg", "Sidorov", "Sidorovich", 'D', "CIT", "Comp Logic", new DateTime(2001, 8, 23), new DateTime(2020, 7, 20), 99);
            arr.AddStudent(st3);
            arr.GetStudent(2);

            Console.WriteLine("Удаление-----------------------------------------------");
            arr.RemoveElement(1);
            arr.Print();

            Console.WriteLine("Вставка-----------------------------------------------");
            arr.InsertStudent(0, st2);
            arr.Print();
            Console.WriteLine("Количество элементов в контейнере: " + arr.Size());

            foreach (Student stud in arr)
            {
                stud.GetInfo();
            }

            Console.WriteLine("Очистка-----------------------------------------------");
            arr.RemoveAll();
            if(arr.Size() == 0)
            {
                Console.WriteLine("Контейнер пуст");
            }
        }
    }
}
