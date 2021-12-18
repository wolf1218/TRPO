using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo.core;

namespace trpo.Goncharov
{
    class GoncharovExeption : Exception
    {
        public GoncharovExeption(string message)
        : base(message)
        { }
    }
}
