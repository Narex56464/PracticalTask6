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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int a, b, a1, b1, c;

            a = Convert.ToInt32(Tba.Text);
            b = Convert.ToInt32(Tbb.Text);
            a1 = Convert.ToInt32(Tba1.Text);
            b1 = Convert.ToInt32(Tbb1.Text);
            c = Convert.ToInt32(Tbc.Text);

            Task1 task1 = new Task1(a, b, a1, b1, c);

            TbA.Text = $"a) {task1.ExpA()}";
            TbB.Text = $"b) {task1.ExpB()}";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            Tbc.Text = string.Empty;
            Tba1.Text = string.Empty;
            Tbb1.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task2Page());
        }
    }
}
