using PL_Tutorial.Window_Menu;
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

namespace PL_Tutorial.Pages
{
    /// <summary>
    /// Логика взаимодействия для Dict_Osn_Page.xaml
    /// </summary>
    public partial class Dict_Osn_Page : Window
    {
        public Dict_Osn_Page()
        {
            InitializeComponent();
        }

        //закрыть
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //перезапуск
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Dict_Osn_Page();
            this.Close();
            wind.Show();
        }

        //назад
        private void Btn_Back_Out_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Python();
            wind.Show();
            this.Close();
        }

        //передвижение окна
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
    }
}
