using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task3
    {
        private int _n;
        private int _m;
        private int _k;
        private int _l;

        public Task3(int n, int m, int k, int l)
        {
            _n = n;
            _m = m;
            _k = k;
            _l = l;
        }

        public bool Exp()
        {
            if (_n > _k) return (_n + _m > _k) && _m < _l;
            else return _n + _m > _k;
        }
    }
}
