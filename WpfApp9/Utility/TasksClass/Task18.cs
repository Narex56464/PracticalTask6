using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task18
    {
        private int Price;

        public Task18(int salary)
        {
            Price = salary;
        }

        public double Exp()
        {
            if (Price > 10000 && Price < 20000) return Price * 0.05;
            else if (Price > 20000 && Price < 50000) return Price * 0.1;
            else return Price;
        }
    }
}
