using PL_Tutorial.Dop_Window;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using PL_Tutorial.Dop_Window;

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

        // вызов помощи
        private void Help_U_Click(object sender, RoutedEventArgs e)
        {
            var MesBoxHelps = new MessageBox_Modern("Помощь", "В данном окне расположена информация в смысловых ячейках. Каждая ячейка несет в себе информацию об определенной теме.\n\n- Чтобы прокручивать ячейки, используйте колесико мыши.\n\n- Чтобы просмотреть всю информацию внутри ячейки, выполните следующие шаги:\n   1. Наведитесь на нужную ячейку.\n   2. Нажмите на ее содержимое.\n   3. Используйте стрелку вниз для прокрутки информации вниз.\n   4. Используйте стрелку вверх для прокрутки информации вверх.");
            MesBoxHelps.ShowDialog();
        }
    }
}
