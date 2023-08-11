using PL_Tutorial.Dop_Window;
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
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;


namespace PL_Tutorial.Window_Menu
{
    /// <summary>
    /// Логика взаимодействия для News_AboutApp.xaml
    /// </summary>
    public partial class News_AboutApp : Window
    {
        public News_AboutApp()
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
            Window wind = new News_AboutApp();
            this.Close();
            wind.Show();
        }

        private void Help_U_Click(object sender, RoutedEventArgs e)
        {
            var mesBoxHelp = new MessageBox_Modern("Помощь", $"В данном окне, представлена лента с информацией о каждом обновлении.\n\n1. Прокручивайте ленту обновлений с помщью колесика мыши. \n2. Если вас что то заинтересовало, нажмите на ячейку и в правой части окна появится вся информация об обновлении. \n3. Чтобы ее прокрутить используйте колесико мыши или нажмите на область где вывелась информация о обновлении, и используйте стролочки ВВЕРХ и ВНИЗ.\n\n\nСправа от \"Стрелочка назад\", находится \"значок-Версионности\", по нажатию на который, вы откроете список всех версий PL-tutorial и после сможете запустить любую версию, чтобы посмотреть как она выглядела несколько обновлений назад!", 400, 465);
            mesBoxHelp.ShowDialog();
        }

        // кнопка списка версий
        private void Btn_Spisok_Versiy_Click(object sender, RoutedEventArgs e)
        {
            if (BorderSpisokVersiy.Visibility == Visibility.Collapsed)
            {
                BorderSpisokVersiy.Visibility = Visibility.Visible;
            }
            else
            {
                BorderSpisokVersiy.Visibility = Visibility.Collapsed;
            }
        }



        // вьювер новостей
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scroll = (ScrollViewer)sender;
            double amount = 20;

            if (e.Delta > 0)
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset + amount);
            }
            else
            {
                scroll.ScrollToVerticalOffset(scroll.VerticalOffset - amount);
            }
            e.Handled = true;
        }



        // !!!!!!!!!!!!!!!!! ТЕКСТ НОВОСТЕЙ !!!!!!!!!!!!!!!!!

        // переключение стилей в ричБоксе
        private void Button_Click_Info_Change(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string styleKey)
            {
                Style newStyle = FindResource(styleKey) as Style;

                if (newStyle != null)
                {
                    myRichBox.Style = newStyle;
                }
            }
        }


        // прокрутка кнопками рича
        private void MoveRichTextBox(object sender, KeyEventArgs e)
        {
            if (Keyboard.FocusedElement is RichTextBox richTextBox)
            {
                if (e.Key == Key.Up)
                {
                    richTextBox.LineUp();
                    e.Handled = true;
                }
                else
                {
                    richTextBox.LineDown();
                    e.Handled = true;
                }
            }
        }



        // ЗАПУСК ВЕРСИЙ
        private void Btn_0_3_2_12_Click(object sender, RoutedEventArgs e)
        {


            /*string relativePath = @"versions_PL_\vers_0_3_2_12\PythonTutorial_first_.exe";
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = System.IO.Path.Combine(userFolder, relativePath);*/
            try
            {
                

                Process.Start(""); // Запуск файла
            }
            catch
            {
                MessageBox.Show($"Ошибка при запуске .exe файла:", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }




    }
}
