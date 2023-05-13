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
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Input;
//using PL_Tutorial.Pages;
using PL_Tutorial.Window_Menu;
using System.Diagnostics;

namespace PL_Tutorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //перетаскивание окна
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();

        }


        //python-tutor
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_Python wind = new Window_Python();
            wind.Show();
            this.Close();
        }

        //c#-tutor
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window_C_Sharp wind = new Window_C_Sharp();
            wind.Show();
            this.Close();
        }

        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //справка
        private void MenuItem_Spravka_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Menu.Window_Spravka();
            wind.Show();
            this.Close();
        }

        //о приложении
        private void MenuItem_AboutApp_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Menu.Window_Menu();
            wind.Show();
            this.Close();
        }

        //тех поддержка
        private void MenuItem_TehSupport_Click(object sender, RoutedEventArgs e)
        {
            string email = "tehsauppor@gmail.com";
            string subject = "Запрос от пользователя";
            Process.Start($"mailto:{email}?subject={subject}");
        }

        //презагрузка
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new MainWindow();
            this.Close();
            wind.Show();
        }
    }
}
