using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task27
    {
        private double _a;
        private double _b;
        private double _c;

        public Task27(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Exp()
        {
            if(_a < 0)
            {
                double D = Math.Pow(_b, 2) - 4 * _a * _c;
                return D >= 0;
            }
            else return false;
        }
    }
}
