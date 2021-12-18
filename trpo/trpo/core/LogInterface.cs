using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo.core
{
    public interface LogInterface
    {
        void Log(string str);
        void Log(double[] str);
        void Write();
    }
}
