using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task11
    {
        private int Price;

        public Task11(int salary)
        {
            Price = salary;
        }

        public double Exp()
        {
            if (Price > 4000 && Price < 6000) return Price * 0.05;
            else if (Price > 6000 && Price < 10000) return Price * 0.1;
            else return Price;
        }
    }
}
