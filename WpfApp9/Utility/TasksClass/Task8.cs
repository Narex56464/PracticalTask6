using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task8
    {
        private int N;

        public Task8(int n)
        {
            N = n;
        }

        public bool Exp()
        {
            return (N % 3 != 0) && (N % 7 == 0 && N % 10 == 0);
        }
    }
}
