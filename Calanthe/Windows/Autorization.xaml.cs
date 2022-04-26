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
using System.Web;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace Calanthe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        Student user = new Student();
        CalantheEntities db = new CalantheEntities();

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
            int n = 0;

            if (Mail.Text == "" || Password.Password.ToString() == "") MessageBox.Show("Введите данные!");

            else
            {
                foreach (var user in db.Student)
                {
                    if (Mail.Text == user.Email && Password.Password.ToString() == user.Password)
                    {
                        n = 1;
                        break;
                    }
                }
                if (n == 1)
                {
                    Menu _win = new Menu();
                    this.Close();
                    _win.Show();
                    MessageBox.Show("Добро пожаловать!");
                }
                else MessageBox.Show("Такого пользователя не существует!");
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (Mail.Text == "") MessageBox.Show("Введите почту, а потом нажмите сюда ещё раз!");
            else
            {
                foreach (var user in db.Student)
                {
                    if (Mail.Text == user.Email)
                    {
                        n = 1;
                        break;
                    }
                }

                if (n == 1)
                {
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[8];
                    var random = new Random();

                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }
                    var finalString = new String(stringChars);
                    MailAddress from = new MailAddress("Calanthe.RusoIdioma@mail.ru", "Calanthe");
                    MailAddress to = new MailAddress(Mail.Text);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Восстановление пароля";
                    m.Body = "Ваш новый пароль:" + finalString;
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("Calanthe.RusoIdioma@mail.ru", "123qweQWE!@#");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    MessageBox.Show("Пароль отправлен на Вашу почту! После его получения авторизуйтесь с помощью него!");

                }
                else MessageBox.Show("Пользователя с такой электронной почтой не существует!");


            }
        }

        private void NewPassword_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (Mail.Text == "") MessageBox.Show("Введите почту, а потом нажмите сюда ещё раз!");
            else
            {
                foreach (var user in db.Student)
                {
                    if (Mail.Text == user.Email)
                    {
                        n = 1;
                        break;
                    }
                }

                if (n == 1)
                {
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[8];
                    var random = new Random();

                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }
                    var finalString = new String(stringChars);
                    MailAddress from = new MailAddress("calanthe.rusoidioma@mail.ru", "123qweQWE!@#");
                    MailAddress to = new MailAddress(Mail.Text);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Восстановление пароля";
                    m.Body = "Ваш новый пароль:" + finalString;
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("Calanthe.RusoIdioma@mail.ru", "123qweQWE!@#");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    MessageBox.Show("Пароль отправлен на Вашу почту! После его получения авторизуйтесь с помощью него!");

                }
                else MessageBox.Show("Пользователя с такой электронной почтой не существует!");

            }
        }
    }
}

//SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
//Smtp.Credentials = new NetworkCredential("Calanthe.RusoIdioma@mail.ru", "123qweQWE!@#");
//Smtp.EnableSsl = false;

//MailMessage message = new MailMessage();
//message.From = new MailAddress("Calanthe.RusoIdioma@mail.ru");
//message.To.Add(new MailAddress(Mail.Text));
//message.Subject = "Восстановление пароля";
//message.Body = "Ваш новый пароль:" + finalString;
//Smtp.Send(message);
//MessageBox.Show("Пароль отправлен на Вашу почту! После его получения авторизуйтесь с помощью него!");