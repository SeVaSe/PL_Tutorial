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
using System.Reflection;

namespace PL_Tutorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TimeWaintPrint = 10; //задержка между печатаемыми символами (в миллисекундах)
        private const string TextType = "\t      Добро пожаловать в PL-Tutorial!\n\n" +

            "PL-Tutorial - информативное приложение-справочник, помогающее вам найти все необходимые ресурсы, примеры кода и объяснения для изучения различных языков программирования и технологий." +
            "\r\n\r\nPL-Tutorial создан с целью помочь вам освоить новые навыки и развиться в области программирования. Здесь вы найдете четкие объяснения, сопровожденные примерами, чтобы легко усваивать новый материал." +
            "\r\n\r\nНезависимо от вашего уровня подготовки, в справочнике вы найдете материалы от начального до продвинутого уровня, а также информацию по отдельным технологиям языков и многое другое, " +
            "что поможет вам расширить свои знания и улучшить навыки программирования.";
        

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            version_blok();
        }

        string vers_curs = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        
        public void version_blok()
        {
            TxtBl_vers.Text = vers_curs;
        }
        





        //ГПТ ФУНКЦИЯ ----------------------------------------------

        //вылет окна GPT
        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Thickness expandedMargin = new Thickness(30, 36, 12, 54); // Новое значение Margin для полного вывода Border_GPT

            Border_GPT.BeginAnimation(FrameworkElement.MarginProperty, new ThicknessAnimationUsingKeyFrames()
            {
                KeyFrames = new ThicknessKeyFrameCollection()
        {
            new EasingThicknessKeyFrame(new Thickness(Border_GPT.Margin.Left, Border_GPT.Margin.Top, Border_GPT.Margin.Right, Border_GPT.Margin.Bottom), TimeSpan.Zero),
            new EasingThicknessKeyFrame(expandedMargin, TimeSpan.FromSeconds(0.5), new ElasticEase() { EasingMode = EasingMode.EaseOut, Oscillations = 2, Springiness = 10 })
        }
            });
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Thickness originalMargin = new Thickness(264, 36, -26, 54);

            Border_GPT.BeginAnimation(FrameworkElement.MarginProperty, new ThicknessAnimationUsingKeyFrames()
            {
                KeyFrames = new ThicknessKeyFrameCollection()
        {
            new EasingThicknessKeyFrame(new Thickness(Border_GPT.Margin.Left, Border_GPT.Margin.Top, Border_GPT.Margin.Right, Border_GPT.Margin.Bottom), TimeSpan.Zero),
            new EasingThicknessKeyFrame(originalMargin, TimeSpan.FromSeconds(0.5), new ElasticEase() { EasingMode = EasingMode.EaseOut, Oscillations = 2, Springiness = 10 })
        }
            });
        }

        //кнопка на переход в GPT окно
        private void Button_GPT(object sender, RoutedEventArgs e)
        {
            Window windGPT = new GPT_Wind();
            windGPT.Show();
        }

        //ГПТ ФУНКЦИЯ ----------------------------------------------



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





        //РАБОТА С ОКНОМ ----------------------------------------------

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

        //новости о приложении
        private void News_AboutApp_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Menu.News_AboutApp();
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

        //РАБОТА С ОКНОМ ----------------------------------------------

    }
}
