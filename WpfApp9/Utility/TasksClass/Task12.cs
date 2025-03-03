﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task12
    {
        private int _n;
        private int _m;
        private int _k;
        private int _l;

        public Task12(int n, int m, int k, int l)
        {
            _n = n;
            _m = m;
            _k = k;
            _l = l;
        }

        public bool Exp()
        {
            if (_k > 0) return 2 * _m < _l;
            else if (_k < 0) return true;
            else return (_k + _l + _m + _n) > 0;
        }
    }
}
