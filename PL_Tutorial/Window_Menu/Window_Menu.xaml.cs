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

namespace PL_Tutorial.Window_Menu
{
    /// <summary>
    /// Логика взаимодействия для Window_Menu.xaml
    /// </summary>
    public partial class Window_Menu : Window
    {
        public Window_Menu()
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

        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //выйти
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //перетаскивание окна
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

        //перезагрузка
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Menu();
            this.Close();
            wind.Show();
        }


        //прокрутка вьювера
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollView = (ScrollViewer)sender;
            double amountSpeed = 30;
            if (e.Delta < 0)
            {
                scrollView.ScrollToHorizontalOffset(scrollView.HorizontalOffset + amountSpeed);
            }
            else
            {
                scrollView.ScrollToHorizontalOffset(scrollView.HorizontalOffset - amountSpeed);
            }

            e.Handled = true;
        }


        //прокрутка сожержимого в рич-боксах
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.FocusedElement is RichTextBox richTextBox)
            {
                if (e.Key == Key.Up)
                {
                    richTextBox.LineUp();
                    e.Handled = true;
                }
                else if (e.Key == Key.Down)
                {
                    richTextBox.LineDown();
                    e.Handled = true;
                }
            }
        }




    }
}
