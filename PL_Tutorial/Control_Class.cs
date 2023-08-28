using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PL_Tutorial
{
    public class Control_Class
    {
        /*КЛАСС КОНТРОЛЕ ОКОН*/
        private Window _wind;

        public Control_Class(Window wind)
        {
            _wind = wind;
        }

        //закрыть
        public void close_cl(object sender, RoutedEventArgs e)
        {
            _wind.Close();
        }

        //свернуть
        public void minimazed_cl(object sender, RoutedEventArgs e)
        {
            _wind.WindowState = WindowState.Minimized;
        }

        //перезапуск
        public void perezapusk_cl(Window newWind )
        {
            newWind.Show();
            _wind.Close();
        }

        //назад
        public void back_out_cl(object sender, RoutedEventArgs e)
        {
            Window windPyMain = new Window_Menu.Window_Python();
            windPyMain.Show();
            _wind.Close();
        }


        //передвижение окна
        public void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                _wind.DragMove();
        }

        public void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                _wind.DragMove();

        }


    }
}
