using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace hizliyaz
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        DispatcherTimer tm = new DispatcherTimer();

        public void StartTimer(object o,RoutedEventArgs sender) 
        
        {

            tm.Interval = new TimeSpan(0,0,0,0,225);
            tm.Tick += new EventHandler(Each_Tick);

        
        }
        int i = 10;
        public void Each_Tick(object o, EventArgs sender)
        {
            sure.Text = i--.ToString(); if (i == -1)
            {
                tm.Stop();
            }
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            b1.Width = 237;
        }

        private void b1_MouseLeave(object sender, MouseEventArgs e)
        {
            b1.Width = 232;
        }

        private void b2_MouseEnter(object sender, MouseEventArgs e)
        {
            b2.Width = 237;
        }

        private void b2_MouseLeave(object sender, MouseEventArgs e)
        {
            b2.Width = 232;
        }

        private void b3_MouseEnter(object sender, MouseEventArgs e)
        {
            b3.Width = 237;
        }

        private void b3_MouseLeave(object sender, MouseEventArgs e)
        {
            b3.Width = 232;
        }

        private void b4_MouseEnter(object sender, MouseEventArgs e)
        {
            b4.Width = 237;
        }

        private void b4_MouseLeave(object sender, MouseEventArgs e)
        {
            b4.Width = 232;
        }

        private void b4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Browser.HtmlPage.Window.Invoke("close");
        }

        private void b2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bu oyun 12A sınıfı 11108 nolu öğrencisi Berke KIRAN tarafından giu. performans ödevi amacı ile yapılmıştır.");
        }

        private void b1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tm.Start();
            b1.Visibility = System.Windows.Visibility.Collapsed;
            b2.Visibility = System.Windows.Visibility.Collapsed;
            b3.Visibility = System.Windows.Visibility.Collapsed;
            b4.Visibility = System.Windows.Visibility.Collapsed;
            im1.Visibility = System.Windows.Visibility.Collapsed;
            im2.Visibility = System.Windows.Visibility.Visible;
            im3.Visibility = System.Windows.Visibility.Visible;
            im4.Visibility = System.Windows.Visibility.Visible;
            b5.Visibility = System.Windows.Visibility.Visible;
            k1.Visibility = System.Windows.Visibility.Visible;
            k2.Visibility = System.Windows.Visibility.Visible;
            k3.Visibility = System.Windows.Visibility.Visible;
            skor.Visibility = System.Windows.Visibility.Visible;
            sure.Visibility = System.Windows.Visibility.Visible;
            t1.Visibility = System.Windows.Visibility.Visible;
            k1.Text = "ilk";
        }

        private void b3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Oyunda amaç hızlı yazmaktır size verilen kelimeleri 10 saniye içerisinde yazarak puan toplamanız gerekir.");
        }

        private void b5_MouseEnter(object sender, MouseEventArgs e)
        {
            b5.Width = 129;
        }

        private void b5_MouseLeave(object sender, MouseEventArgs e)
        {
            b5.Width = 125;
        }

        private void b5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tm.Stop();
            next.Visibility = System.Windows.Visibility.Visible;
            if (sure.Text != "0") 
            
            { 
            
            if(t1.Text == k1.Text)
            
            {

                skor.Text = "100";
                k1.Text = "Başardın !!";
            }  else { k1.Text = "Başaramadın !!" ;}


            }
            else { k1.Text = "Başaramadın !!"; }
            b5.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void next_MouseEnter(object sender, MouseEventArgs e)
        {
            next.Width = 51;
        }

        private void next_MouseLeave(object sender, MouseEventArgs e)
        {
            next.Width = 47;
        }

        private void next_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Oyun geliştirme aşamasında old. için sadece 1 kelime bulunmaktadır.Bu projedeki amaç photoshop,c#,timer,mouseenter ya da leave, visibility gibi fonksyonları ve programları kullanabilmeyi sunmaktır.");
        }
    }
}
