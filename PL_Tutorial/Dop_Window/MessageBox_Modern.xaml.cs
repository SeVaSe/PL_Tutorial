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

namespace PL_Tutorial.Dop_Window
{
    /// <summary>
    /// Логика взаимодействия для MessageBox_Modern.xaml
    /// </summary>
    public partial class MessageBox_Modern : Window
    {
        public MessageBox_Modern(string title, string message, int wid= 100, int heig= 165)
        {
            InitializeComponent();
            TxtBl_NameWarn.Text = title;
            TextBl_MesWarn.Text = message;
            Width = wid; Height = heig;


        }

        //закрыть
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        

        public void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
            
        }

        public void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }


    }
}
