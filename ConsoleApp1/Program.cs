using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Random random = new Random();
            int k1, k2; //Катеты
            double g;   //Гипотенуза
            for (int i = 0; i < 10; i++) //Заполняем, считаем и выводим в консоль
            {
                k1 = random.Next(1, 100);
                k2 = random.Next(1, 100);
                g = Math.Sqrt(k1 * k1 + k2 * k2);
                triangle.SetSides(k1, k2, g);
                Console.WriteLine("Sides:  " + triangle.a + ", " + triangle.b + ", " + triangle.c);
                Console.WriteLine("P / 2:  " + triangle.p);
                Console.WriteLine("Square: " + triangle.Square());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
