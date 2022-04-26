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
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Autorization _win = new Autorization();
            this.Close();
            _win.Show();
        }

        private void Lessons_b_Click(object sender, RoutedEventArgs e)
        {
            Lessons _win = new Lessons();
            this.Close();
            _win.Show();
        }

        private void Dictionary_b_Click(object sender, RoutedEventArgs e)
        {
            Dictionary _win = new Dictionary();
            this.Close();
            _win.Show();
        }

        private void Profile_b_Click(object sender, RoutedEventArgs e)
        {
            Profil _win = new Profil();
            this.Close();
            _win.Show();
        }
    }
}
