using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task16
    {
        private int A;
        private int B;
        private int C;
        private int D;

        public Task16(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public bool Exp()
        {
            return (A % 2 == 0 && B % 2 == 0) ||
                   (A % 2 == 0 && C % 2 == 0) ||
                   (A % 2 == 0 && D % 2 == 0) ||
                   (B % 2 == 0 && C % 2 == 0) ||
                   (B % 2 == 0 && D % 2 == 0) ||
                   (C % 2 == 0 && D % 2 == 0);
        }
    }
}
