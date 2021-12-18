using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo.core
{
    public interface EquationInterface
    {
        List<double> Solve(double a, double b, double c);
    }
}
