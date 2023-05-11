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
    /// Логика взаимодействия для Arifm_Operation.xaml
    /// </summary>
    public partial class Arifm_Operation : Page
    {
        public Arifm_Operation()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Hide();
        }
    }
}
