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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL_Tutorial.Window_Menu
{
    /// <summary>
    /// Логика взаимодействия для Window_Spravka.xaml
    /// </summary>
    public partial class Window_Spravka : Window
    {
        public Window_Spravka()
        {
            InitializeComponent();

        }

        //назад
        private void Btn_Back_Out_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new MainWindow();
            wind.Show();
            this.Close();
        }

        //Свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Закрыть
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //передвижение экрана
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
        
        //перезагрузка
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Spravka();
            this.Close();
            wind.Show();
        }


        // ВЬЮВЕРЫ 1 и 2
        //1
        private void ScrollViewer_PreviewMouseWheel1(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scroll = (ScrollViewer)sender;
            double amountSpeed = 30;

            if (e.Delta > 0)
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset + amountSpeed);
            }
            else
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset - amountSpeed);
            }
            e.Handled = true;
        }
        
        //2
        private void ScrollViewer_PreviewMouseWheel2(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scroll = (ScrollViewer)sender;
            double amountSpeed = 30;

            if (e.Delta > 0)
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset + amountSpeed);
            }
            else
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset - amountSpeed);
            }
            e.Handled = true;
        }
    }
}
