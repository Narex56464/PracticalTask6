using System.Windows;
using WpfApp9.Servers;
using WpfApp9.View.Pages;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MyFrame;

            MyFrame.Navigate(new MainPage());
        }
    }
}
