using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static Random rnd = new Random();
        private static int id = 1;
        static void Main(string[] args)
        {
            var listStudents = new List<Student>();
            Console.WriteLine("Введите кол-во студентов.");
            var length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                listStudents.Add(SetStudent());
            }
            Console.WriteLine(Student.ShowCountToString());

            Console.WriteLine();
            Console.WriteLine("Отличники:");
            foreach (var item in listStudents)
            {
                if (item.Excellent())
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Хорошисты:");
            foreach (var item in listStudents)
            {
                if (item.Good())
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Троечники:");
            foreach (var item in listStudents)
            {
                if (item.Troechnik())
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Список всех студентов:");
            Output(listStudents);
            Console.ReadLine();
        }


        private static void Output(IEnumerable collection)
        {
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Cписок пуст.");
            }
        }
        private static Student SetStudent()
        {
            //Console.WriteLine("Введите ФИО ученика.");
            //var fullName = InputValidFullName();
            var fullName = "Test " + GenerateNumber(10, 90);
            var evaluations = new int[3];
            for (int i = 0; i < evaluations.Length; i++)
            {
                evaluations[i] = GenerateNumber(3, 6);
            }
            return new Student(id++, fullName, evaluations);
        }
        private static int GenerateNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }
        private static string InputValidFullName()
        {
            while (true)
            {
                string[] checkName;
                var fullName = Console.ReadLine();
                checkName = fullName.Split(' ');
                if (checkName.Length == 3)
                {
                    return fullName;
                }
                else
                {
                    Console.WriteLine($"Введите полное имя!");
                }
            }
        }
    }
}
