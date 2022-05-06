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
using Microsoft.Win32;
using System.IO;

namespace Calanthe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class EditProfil : Window
    {
        string mail;
        string password;
        String filename;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] buffer;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".docx";
            dlg.Filter = "Text documents (.png; .jpg) | *.png;*.jpg;";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                filename = dlg.FileName;
                buffer = File.ReadAllBytes(filename);
                try
                {
                    Student student = new Student();
                    foreach (var user in db.Student)
                    {
                        if (Mail.Text == user.Email)
                        {
                            user.Image = buffer;
                            break;
                        }
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void GoOut_b_Click(object sender, RoutedEventArgs e)
        {
            Login.Text = null;
            Mail.Text = null;
            Password.Text = null;
            Autorization _win = new Autorization();
            this.Close();
            _win.Show();
        }
    }
}
