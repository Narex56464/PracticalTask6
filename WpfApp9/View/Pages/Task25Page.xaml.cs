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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c, d;

            a = Convert.ToInt32(Tba.Text);
            b = Convert.ToInt32(Tbb.Text);
            c = Convert.ToInt32(Tbc.Text);
            d = Convert.ToInt32(Tbd.Text);

            Task25 task25 = new Task25(a, b, c, d);

            TbA.Text = $"{task25.Exp()}";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            Tbc.Text = string.Empty;
            Tbd.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task26Page());
        }
    }
}
