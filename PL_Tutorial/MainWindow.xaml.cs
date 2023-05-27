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
using PL_Tutorial.Pages;
using PL_Tutorial.Window_Menu;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace PL_Tutorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TimeWaintPrint = 20; //задержка между печатаемыми символами (в миллисекундах)
        private const string TextType = "\t      Добро пожаловать в PL-Tutorial!\n\n" +

            "PL-Tutorial - информативное приложение-справочник, помогающее вам найти все необходимые ресурсы, примеры кода и объяснения для изучения различных языков программирования и технологий." +
            "\r\n\r\nPL-Tutorial создан с целью помочь вам освоить новые навыки и развиться в области программирования. Здесь вы найдете четкие объяснения, сопровожденные примерами, чтобы легко усваивать новый материал." +
            "\r\n\r\nНезависимо от вашего уровня подготовки, в справочнике вы найдете материалы от начального до продвинутого уровня, а также информацию по отдельным технологиям языков и многое другое, " +
            "что поможет вам расширить свои знания и улучшить навыки программирования.";

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }



        private void Button_Cl(object sender, RoutedEventArgs e)
        {
            if (mainBorder.Opacity == 0)
            {
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = -mainBorder.ActualWidth,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                mainBorder.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(-mainBorder.ActualWidth, 17, 0, 0), TimeSpan.FromSeconds(0.5)));
                mainBorder.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5)));
            }
            else
            {
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = -mainBorder.ActualWidth,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                mainBorder.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(-mainBorder.ActualWidth, 17, 0, 0), TimeSpan.FromSeconds(0.5)));
                mainBorder.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5)));
            }


        }






        //печать текста приветствия
        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await PrintTextAsy(TextType, TxtBl_HeySoo);
        }

        private async Task PrintTextAsy(string text, TextBlock txtBlock)
        {
            foreach (char item in text)
            {
                txtBlock.Text += item;
                await Task.Delay(TimeWaintPrint);
            }
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
