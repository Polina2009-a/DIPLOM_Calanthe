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
using System.Diagnostics;

namespace Calanthe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _win = new MainWindow();
            this.Close();
            _win.Show();
        }

        private void registration_b_Click_1(object sender, RoutedEventArgs e)
        {
            Registration _win = new Registration();
            this.Close();
            _win.Show();
        }

        private void Continue_b_Click_1(object sender, RoutedEventArgs e)
        {
            Menu _win = new Menu();
            this.Close();
            _win.Show();
        }
    }
}
