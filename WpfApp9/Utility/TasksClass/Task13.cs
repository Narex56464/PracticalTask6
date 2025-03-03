using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task13
    {
        private double _t;
        private double _dt;
        private double _s;
        private double _d;

        public Task13(double t, double dt, double s, double d)
        {
            _t = t;
            _dt = dt;
            _s = s;
            _d = d;
        }

        public double Exp()
        {
            if ((_t >= 22 && _t <= 24) && (_t >= 0 && _t <= 8))
            {
                if (_d == 6 || _d == 7) return ((_dt * _s) * 0.2) * 0.1;
                else return (_dt * _s) * 0.2;
            }
            else return _dt * _s;
        }
    }
}
