using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo.core;

namespace trpo.Goncharov
{
    class GoncharovLog : LogAbstract, LogInterface
    {
        private List<string> LogString = new List<string>();
        protected GoncharovLog() { }

        private static GoncharovLog _instance;

        public static GoncharovLog I()
        {
            if (_instance == null)
            {
                _instance = new GoncharovLog();
            }
            return _instance;
        }

        public void Log(string s)
        {

            LogString.Add(s);
        }

        public void Log(double[] str)
        {
            string temp = "Корень(ни) уравнения: ";
            foreach (double i in str)
            {
                temp = temp + Convert.ToString(i) + " ";
            }
            LogString.Add(temp);
        }

        public void Write()
        {
            writeConsole(LogString.ToArray());
        }
    }
}
