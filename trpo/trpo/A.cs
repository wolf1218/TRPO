using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo
{
    class A
    {
        protected double[] x;

        public double[] Solve1(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Корней уравнения не существует.");
            }


            return this.x = new double[] { ((-b) / a) };


        }
    }
}
