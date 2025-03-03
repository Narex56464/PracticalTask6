using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task19
    {
        private double Salary;
        private int Experience;

        public Task19(double salary, int experience)
        {
            Salary = salary;
            Experience = experience;
        }

        public double SurCharge()
        {
            if (Experience >= 5 && Experience <= 10) return Salary * 0.02 * Experience;
            else if(Experience >= 10 &&  Experience <= 20) return Salary * 0.1 * Experience;
            else return Salary;
        }
    }
}
