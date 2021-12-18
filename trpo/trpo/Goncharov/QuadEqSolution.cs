using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using trpo.core;
using System.Threading.Tasks;


namespace trpo.Goncharov
{
    class QuadEqSolution : EquationSolution, EquationInterface
    {
        protected double Calc_discriminant(double a, double b, double c)
        {
            return ((b * b) - 4 * a * c);
        }

        public List<double> Solve(double a, double b, double c)
        {

            if (a == 0)
            {
                return Solve1(b, c);
            }

            double D = Calc_discriminant(a, b, c);
            GoncharovLog.I().Log("Определено, что данное уравнение является линейным");
            if (D < 0)
            {
                throw new GoncharovExeption("Уравнение не имеет решений.");
            }
            if (D == 0)
            {
                return x = new List<double> { (-b + Math.Sqrt(D)) / (2 * a) };
            }
            else
            {
                return x = new List<double> { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
            }
        }
    }
}
