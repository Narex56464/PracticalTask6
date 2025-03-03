using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task7
    {
        private int N;

        public Task7(int n)
        {
            N = n;
        }

        public bool Exp()
        {
            return (N % 7 == 0) && (N % 11 != 0 && N % 10 != 0);
        }
    }
}
