using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.Solve1(10, 5)[0].ToString());



            Console.ReadKey();
        }
    }
}
