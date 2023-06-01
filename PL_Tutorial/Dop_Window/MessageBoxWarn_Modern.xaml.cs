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
    /// Логика взаимодействия для MessageBoxWarn_Modern.xaml
    /// </summary>
    public partial class MessageBoxWarn_Modern : Window
    {
        public MessageBoxWarn_Modern()
        {
            InitializeComponent();
        }

        //закрытие
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }




    }
}
