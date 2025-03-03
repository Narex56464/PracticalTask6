using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task2
    {
        private int N;
        private int N1;

        public Task2(int n, int n1)
        {
            N = n;
            N1 = n1;
        }

        public bool ExpA()
        {
            return (N % 4 == 0 || N % 7 == 0);
        }

        public bool ExpB()
        {
            return (N1 % 5 == 0 && N1 % 10 != 0);
        }
    }
}
