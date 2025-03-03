using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task26
    {
        private int N;

        public Task26(int n)
        {
            N = n;
        }

        public bool Exp()
        {
            return (N % 5 != 0) && (N % 2 == 0 && N % 3 == 0);
        }
    }
}
