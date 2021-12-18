using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo
{
    class B : A
    {
        protected double Calc_discriminant(double a, double b, double c)
        {
            return ((b * b) - 4 * a * c);
        }

        public double[] Solve2(double a, double b, double c)
        {

            if (a == 0)
            {
                return Solve1(b, c);
            }

            double D = Calc_discriminant(a, b, c);
            if (D < 0)
            {
                throw new Exception("Корней уравнения не существует.");
            }
            if (D == 0)
            {
                return x = new double[] { (-b + Math.Sqrt(D)) / (2 * a) };
            }
            else
            {
                return x = new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
            }
        }
    }
}
