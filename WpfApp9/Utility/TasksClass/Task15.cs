using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task15
    {
        private int _ph;
        private int _math;
        private int _info;

        public Task15(int ph, int math, int info)
        {
            _ph = ph;
            _math = math;
            _info = info;
        }

        public bool Exp()
        {
            return (_ph == 4 || _ph == 5) && (_math == 4 || _math == 5) && (_info == 4 || _info == 5);
        }
    }
}
