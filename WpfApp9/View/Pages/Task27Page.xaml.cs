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
    /// Логика взаимодействия для Task27Page.xaml
    /// </summary>
    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;

            a = Convert.ToDouble(Tba.Text);
            b = Convert.ToDouble(Tbb.Text);
            c = Convert.ToDouble(Tbc.Text);

            Task27 task27 = new Task27(a, b, c);

            if (task27.Exp())
                TbA.Text = "уравнение имеет действительные корни";
            else
                TbA.Text = "уравнение не имеет действительные корни";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            Tbc.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
