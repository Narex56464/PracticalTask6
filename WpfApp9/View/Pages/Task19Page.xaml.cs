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
    /// Логика взаимодействия для Task19Page.xaml
    /// </summary>
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double salary = Convert.ToDouble(Tbs.Text);
            int experience = Convert.ToInt32(Tbexp.Text);

            Task19 task19 = new Task19(salary, experience);

            TbA.Text = $"Надбавка = {task19.SurCharge()}";

            Tbs.Text = string.Empty;
            Tbexp.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task20Page());
        }
    }
}
