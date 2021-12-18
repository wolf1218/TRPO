using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo.core;

namespace trpo.Goncharov
{
    class EquationSolution
    {
        protected List<double> x;

        public List<double> Solve1(double a, double b)
        {
            if (a == 0)
            {
                throw new GoncharovExeption("Уравнения не существует.");
            }

            GoncharovLog.I().Log("Определено, что данное уравнение является линейным");
            return this.x = new List<double> { ((-b) / a) };


        }
    }
}
