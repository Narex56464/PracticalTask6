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

namespace WpfApp9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();

            bool result;

            result = !(Convert.ToBoolean(0) && Convert.ToBoolean(0)) || (Convert.ToBoolean(0) && !Convert.ToBoolean(0));
            Tb0.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(0) && Convert.ToBoolean(0)) || (Convert.ToBoolean(0) && !Convert.ToBoolean(1));
            Tb1.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(0) && Convert.ToBoolean(1)) || (Convert.ToBoolean(0) && !Convert.ToBoolean(0));
            Tb2.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(1) && Convert.ToBoolean(0)) || (Convert.ToBoolean(1) && !Convert.ToBoolean(0));
            Tb3.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(0) && Convert.ToBoolean(1)) || (Convert.ToBoolean(0) && !Convert.ToBoolean(1));
            Tb4.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(1) && Convert.ToBoolean(1)) || (Convert.ToBoolean(1) && !Convert.ToBoolean(0));
            Tb5.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(1) && Convert.ToBoolean(0)) || (Convert.ToBoolean(1) && !Convert.ToBoolean(1));
            Tb6.Text = $"    {Convert.ToInt32(result)}";

            result = !(Convert.ToBoolean(1) && Convert.ToBoolean(1)) || (Convert.ToBoolean(1) && !Convert.ToBoolean(1));
            Tb7.Text = $"    {Convert.ToInt32(result)}";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task15Page());
        }
    }
}
