using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9.Utility.TasksClass
{
    public class Task21
    {
        private int Experience;

        public Task21(int exp)
        {
            Experience = exp;
        }

        public string Exp()
        {
            if (Experience <= 2) return "Коэффициент равен 11";
            else if (Experience >= 2 && Experience <= 5) return "Коэффициент равен 12";
            else return "Коэффициент равен 13";
        }
    }
}
