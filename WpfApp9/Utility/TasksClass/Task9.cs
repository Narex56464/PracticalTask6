using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task9
    {
        private int _n;
        private int _m;
        private int _k;
        private int _l;

        public Task9(int n, int m, int k, int l)
        {
            _n = n;
            _m = m;
            _k = k;
            _l = l;
        }

        public bool Exp()
        {
            if (_k == 0) return _l > _m;
            else if (_k < 0) return 2 * _l - 3 * _n < _m;
            else return false;
        }
    }
}
