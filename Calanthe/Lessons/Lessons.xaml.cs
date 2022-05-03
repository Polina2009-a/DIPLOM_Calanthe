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
    public partial class Lessons : Window
    {
        string mail;
        public Lessons(string mail)
        {
            InitializeComponent();
            this.mail = mail;
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Menu _win = new Menu(mail);
            this.Close();
            _win.Show();
        }

        private void Dictionary_b_Click(object sender, RoutedEventArgs e)
        {
            Dictionary _win = new Dictionary(mail);
            this.Close();
            _win.Show();
        }

        private void ViewLesson(object sender, RoutedEventArgs e)
        {
            PanelMenu.Visibility = Visibility.Visible;
            Dictionary_b.Visibility = Visibility.Visible;
            Dictionary_b.Visibility = Visibility.Visible;
            Back_b2.Visibility = Visibility.Visible;
            Back_b.Visibility = Visibility.Hidden;
            PanelLessons.Visibility = Visibility.Hidden;
        }

        private void Back_b2_Click(object sender, RoutedEventArgs e)
        {
            PanelMenu.Visibility = Visibility.Hidden;
            Dictionary_b.Visibility = Visibility.Hidden;
            Dictionary_b.Visibility = Visibility.Hidden;
            Back_b2.Visibility = Visibility.Hidden;
            Back_b.Visibility = Visibility.Visible;
            PanelLessons.Visibility = Visibility.Visible;
        }

        private void Practic_b_Click(object sender, RoutedEventArgs e)
        {
            Practice _win = new Practice(mail);
            this.Close();
            _win.Show();
        }
    }
}
