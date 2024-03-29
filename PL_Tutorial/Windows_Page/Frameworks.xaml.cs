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
using System.Windows.Shapes;

namespace PL_Tutorial.Windows_Page
{
    /// <summary>
    /// Логика взаимодействия для Frameworks.xaml
    /// </summary>
    public partial class Frameworks : Window
    {
        public Frameworks()
        {
            InitializeComponent();
        }

        //перетаскивание окон
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //кнопка назад
        private void Btn_Back_Out_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Menu.Window_Python();
            wind.Show();
            this.Close();
        }

        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //свернуть
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //перезагр
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Frameworks();
            this.Close();
            wind.Show();
        }
    }
}
