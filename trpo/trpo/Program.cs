using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo.Goncharov;
using trpo.core;

namespace trpo
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadEqSolution q = new QuadEqSolution();
            GoncharovLog log = GoncharovLog.I();
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            log.Log(a.ToString());
            log.Log(b.ToString());
            log.Log(c.ToString());
            try
            {
                log.Log(a + "x^2 + " + b + "x + " + c + " = 0");
                log.Log(q.Solve(a, b, c).ToArray());
            }
            catch (GoncharovExeption e)
            {
                log.Log(e.Message);
            }
            log.Write();

            Console.ReadKey();
        }
    }
}
