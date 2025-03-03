using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task6
    {
        private int Salary;

        public Task6(int salary)
        {
            Salary = salary;
        }

        public double Exp()
        {
            if (Salary < 50000) return Salary + (0.16 * Salary);
            else if (Salary >= 50000 && Salary <= 100000) return Salary + (0.18 * Salary);
            else return Salary;
        }
    }
}
