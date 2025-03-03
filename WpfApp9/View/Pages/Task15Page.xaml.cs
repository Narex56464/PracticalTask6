using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp9.Servers;
using WpfApp9.Utility.TasksClass;

namespace WpfApp9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int math, info, phisics;

            math = Convert.ToInt32(Tbmath.Text);
            info = Convert.ToInt32(Tbinfo.Text);
            phisics = Convert.ToInt32(Tbph.Text);

            Task15 task15 = new Task15(phisics, math, info);

            if (task15.Exp())
                TbA.Text = "Студент получит стипендию";
            else
                TbA.Text = "Студент не получит стипендию";

            Tbmath.Text = string.Empty;
            Tbinfo.Text = string.Empty;
            Tbph.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task16Page());
        }
    }
}
