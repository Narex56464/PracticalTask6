using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp9.Servers;
using WpfApp9.Utility.TasksClass;

namespace WpfApp9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int sal = Convert.ToInt32(Tbs.Text);

            Task6 task6 = new Task6(sal);

            TbA.Text = $"Зарплата = {task6.Exp()}";

            Tbs.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task7Page());
        }
    }
}
