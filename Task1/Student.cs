using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        private int Id { get; set; }
        private string FullName { get; }
        private int[] Evaluations { get; } = new int[3];
        private static int ExcellentsCount { get; set; } = 0;
        private static int GoodsCount { get; set; } = 0;
        private static int TroechnikiCount { get; set; } = 0;

        public Student(int id, string fullName, int[] evaluations)
        {
            Id = id;
            FullName = fullName;
            Evaluations = evaluations;
            CounterEvaluations();
        }

        public static string ShowCountToString()
        {
            return $"Отличники: {ExcellentsCount}\nХорошисты: {GoodsCount}\nТроечники: {TroechnikiCount}\n";
        }

        public bool Excellent()
        {
            var count = 0;
            for (int i = 0; i < Evaluations.Length; i++)
            {
                if (Evaluations[i] == 5)
                {
                    count++;
                }
                if (count == 3)
                {
                    ExcellentsCount++;
                    return true;
                }
            }
            return false;
        }
        public bool Good()
        {
            var count = 0;
            for (int i = 0; i < Evaluations.Length; i++)
            {
                if (Evaluations[i] == 3)
                {
                    return false;
                }
                else if (Evaluations[i] == 4)
                {
                    count++;
                }
                else if(Evaluations[i] == 5)
                {
                    count++;
                }            
            }
            if (count >= 3 && count < 6)
            {
                GoodsCount++;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Troechnik()
        {
            for (int i = 0; i < Evaluations.Length; i++)
            {
                if (Evaluations[i] == 3)
                {
                    TroechnikiCount++;
                    return true;
                }            
            }
            return false;
        }

        private void CounterEvaluations()
        {
            Excellent();
            Good();
            Troechnik();
        }
        public override string ToString()
        {
            return $"№{Id}| {FullName} | Оценки: {Evaluations[0]}, {Evaluations[1]}, {Evaluations[2]}";
        }
    }
}
