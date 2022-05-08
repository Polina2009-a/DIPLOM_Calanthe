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
using System.IO;
using System.Windows.Media.Converters;

namespace Calanthe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Profil : Window
    {
        string mail;
        Student user = new Student();
        CalantheEntities db = new CalantheEntities();
        byte[] buffer;

        public Profil(string mail)
        {
            InitializeComponent();
            this.mail = mail;
            
            foreach (var user in db.Student)
            {
                if (mail == user.Email)
                {
                    //user.Image = buffer;
                   //Image image = byteArrayToImage(buffer);
                    imageEllipse.Fill = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Полина\Desktop\Calanthe\Calanthe\Registration\ziro_foto.png")));
                    break;
                }
            }
        }

        private void Continue_b_Click(object sender, RoutedEventArgs e)
        {
            EditProfil _win = new EditProfil(mail);
            this.Close();
            _win.Show();
        }

        private void Back_b_Click(object sender, RoutedEventArgs e)
        {
            Menu _win = new Menu(mail);
            this.Close();
            _win.Show();
        }
    }
}
