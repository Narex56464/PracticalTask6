﻿using System;
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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int n, m, k, l;

            n = Convert.ToInt32(Tbn.Text);
            m = Convert.ToInt32(Tbm.Text);
            k = Convert.ToInt32(Tbk.Text);
            l = Convert.ToInt32(Tbl.Text);

            Task5 task5 = new Task5(n, m, k, l);

            TbA.Text = $"{task5.Exp()}";

            Tbn.Text = string.Empty;
            Tbm.Text = string.Empty;
            Tbk.Text = string.Empty;
            Tbl.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task6Page());
        }
    }
}
