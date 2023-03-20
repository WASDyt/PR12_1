using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classwork = { "Аня", "Саша", "Валя",
                "Вика", "Снежана" , "Алина", "Яна", "Алла","Елена"};
            
            string[] classwork1 = { "Аня",
                "Саша", "Валя",
                "Вика", "Снежана" };
            string[] classwork2 = { "Аня",
                "Вика", "Снежана" };
            string[] classwok3 = { "Аня",
                "Вика", "Алина", "Яна",
                "Алла", "Снежана" };
            Console.WriteLine("Встречаются во всех параллельных классах");
            Print_mnozh(classwork1.Intersect(classwork2).Intersect(classwok3));
            Console.WriteLine("Ни в одном классе не встречаются");
            Print_mnozh(classwork.Except(classwork1).Except(classwork2).Except(classwok3));
            Console.WriteLine("Встречаются в некоторых классах");
            Print_mnozh(classwork1.Union(classwork2).Union(classwok3).
                Except(classwork1.Intersect(classwork2).Intersect(classwok3)));
            Console.ReadKey();

        }
        private static void Print_mnozh(IEnumerable<string> res)
        {
            foreach (string s in res)
                Console.WriteLine(s);
        }
    }
}
