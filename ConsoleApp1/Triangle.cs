using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle
    {
        public int a;
        public int b;
        public double c;
        public double p;

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
            p = 0;
        }
        
        public Triangle(int SideA, int SideB, double SideC)
        {
            a = SideA;
            b = SideB;
            c = SideC;
            p = (a + b + c) / 2;
        }

        public void SetSides(int SideA, int SideB, double SideC)
        {
            a = SideA;
            b = SideB;
            c = SideC;
            p = (a + b + c) / 2;
        }

        // В условии сказано, что треугольник прямоугольный, поэтому
        // было бы логичнее считать его как половину произведения катетов
        // но ладно, по трём сторонам так по трём сторонам
        public double Square()
        {
            double sq;
            sq = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
            return sq;
        }
    }
}
