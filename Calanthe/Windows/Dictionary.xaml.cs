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
using System.Diagnostics;

namespace Calanthe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Dictionary : Window
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Menu _win = new Menu();
            this.Close();
            _win.Show();
        }

        private void Edit_b_Click(object sender, RoutedEventArgs e)
        {
            EditWords _win = new EditWords();
            this.Close();
            _win.Show();
        }
    }
}
