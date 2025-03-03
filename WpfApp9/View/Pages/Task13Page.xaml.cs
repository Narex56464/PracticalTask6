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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double t, dt, s, d;

            t = Convert.ToDouble(Tbt.Text);
            dt = Convert.ToDouble(Tbdt.Text);
            s = Convert.ToDouble(Tbs.Text);
            d = Convert.ToDouble(Tbd.Text);

            Task13 task13 = new Task13(t, dt, s, d);

            TbA.Text = $"{task13.Exp()}";

            Tbt.Text = string.Empty;
            Tbdt.Text = string.Empty;
            Tbs.Text = string.Empty;
            Tbd.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task14Page());
        }
    }
}
