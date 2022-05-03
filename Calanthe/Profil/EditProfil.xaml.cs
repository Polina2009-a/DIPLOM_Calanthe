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
    public partial class EditProfil : Window
    {
        string mail;
        string password;
        Student user = new Student();
        CalantheEntities db = new CalantheEntities();

        public EditProfil(string mail)
        {
            InitializeComponent();
            this.mail = mail;
            Mail.Text = mail;
            foreach (var user in db.Student)
            {
                if (Mail.Text == user.Email)
                {
                    Login.Text = user.Login;
                    Password.Text = user.Password;
                    break;
                }
            }
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Profil _win = new Profil(mail);
            this.Close();
            _win.Show();
        }
    }
}
