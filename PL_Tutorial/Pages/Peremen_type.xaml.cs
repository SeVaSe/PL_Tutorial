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

namespace PL_Tutorial.Pages
{
    /// <summary>
    /// Логика взаимодействия для Peremen_type.xaml
    /// </summary>
    public partial class Peremen_type : Page
    {
        public Peremen_type()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
