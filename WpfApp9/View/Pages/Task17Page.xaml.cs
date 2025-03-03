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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
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

            Task17 task17 = new Task17(a, b, c, d);

            TbA.Text = $"{task17.Exp()}";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            Tbc.Text = string.Empty;
            Tbd.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }
    }
}
