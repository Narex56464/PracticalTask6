using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task4
    {
        private int N;

        public Task4(int n)
        {
            N = n;
        }

        public bool Exp()
        {
            return (N % 3 == 0 && N % 9 != 0) || ((N % 4 == 4) && N % 5 == 0 && N % 24 == 0);
        }
    }
}
