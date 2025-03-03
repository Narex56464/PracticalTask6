using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task10
    {
        private int N;

        public Task10(int n)
        {
            N = n;
        }

        public bool Exp()
        {
            return (N % 2 == 0) && 
                   (N % 3 != 0) && 
                   (N % 7 == 0) && 
                   (N % 5 != 0 || N % 4 != 0) && 
                   (N % 8 == 0 ? N % 11 == 0 : true);  
        }
    }
}
