using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task17
    {
        private int A;
        private int B;
        private int C;
        private int D;

        public Task17(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public bool Exp()
        {
            return (A % 3 == 0 && B % 5 == 0) ||
                   (A % 3 == 0 && C % 5 == 0) ||
                   (A % 3 == 0 && D % 5 == 0) ||
                   (B % 3 == 0 && C % 5 == 0) ||
                   (B % 3 == 0 && D % 5 == 0) ||
                   (C % 3 == 0 && D % 5 == 0) ||
                   (A % 5 == 0 && B % 3 == 0) ||
                   (A % 5 == 0 && C % 3 == 0) ||
                   (A % 5 == 0 && D % 3 == 0) ||
                   (B % 5 == 0 && C % 3 == 0) ||
                   (B % 5 == 0 && D % 3 == 0) ||
                   (C % 5 == 0 && D % 3 == 0);
        }
    }
}
