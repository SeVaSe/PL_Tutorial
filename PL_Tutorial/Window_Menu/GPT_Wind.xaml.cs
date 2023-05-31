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
using System.Windows.Shapes;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;


namespace PL_Tutorial.Window_Menu
{
    /// <summary>
    /// Логика взаимодействия для GPT_Wind.xaml
    /// </summary>
    public partial class GPT_Wind : Window
    {
        public GPT_Wind()
        {
            InitializeComponent();
        }


        // перетаскивание окна
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        //закрытие окна 
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        
        //перезапустить
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new GPT_Wind();
            this.Close();
            wind.Show();
        }





        private async void Btn_GPT_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBl_Vivod_Zapr == null)
            {
                GptModel_Class.Gpt_Work(TxtBox_Gpt_Zapr, TxtBl_Vivod_Zapr);
            }
            else
            {
                TxtBl_Vivod_Zapr.Text = string.Empty;
                GptModel_Class.Gpt_Work(TxtBox_Gpt_Zapr, TxtBl_Vivod_Zapr);
            }
            
        }
        private async void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Btn_GPT_Click(sender, new RoutedEventArgs());
            }

        }

    }


        
}
