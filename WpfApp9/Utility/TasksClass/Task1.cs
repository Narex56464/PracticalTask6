using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task1
    {
        private int A;
        private int B;
        private int A1;
        private int B1;
        private int C;

        public Task1(int a, int b, int a1, int b1, int c)
        {
            A = a;
            B = b;
            A1 = a1;
            B1 = b1;
            C = c;
        }

        public bool ExpA()
        {
            return (A % 2 == 0 &&  B % 2 != 0) || (A % 2 != 0  && B % 2 == 0);
        }

        public bool ExpB()
        {
            return (A1 % 3 == 0) && (B1 % 3 == 0) && (C % 3 == 0);
        }
    }
}
