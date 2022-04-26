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
    public partial class EditWords : Window
    {
        public EditWords()
        {
            InitializeComponent();
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Dictionary _win = new Dictionary();
            this.Close();
            _win.Show();
        }
    }
}
