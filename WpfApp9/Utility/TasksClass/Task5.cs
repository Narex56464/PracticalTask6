using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task5
    {
        private int _n;
        private int _m;
        private int _k;
        private int _l;

        public Task5(int n, int m, int k, int l)
        {
            _n = n;
            _m = m;
            _k = k;
            _l = l;
        }

        public bool Exp()
        {
            if (_n > 2) return (_n > 1 || (_m <= _l + _k && _l + _k == 0)) && (Math.Pow(_m, 2) > Math.Pow(1, 2));
            else return (_n > 1 || (_m <= _l + _k && _l + _k == 0));
        }
    }
}
