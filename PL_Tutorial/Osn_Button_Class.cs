using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Input;
using PL_Tutorial.Pages;
using System.Runtime.CompilerServices;
using PL_Tutorial.Windows_Page;
using System.Security.Cryptography;

namespace PL_Tutorial
{
    public class Osn_Button_Class
    {
        public static void OpenWindow<T>() where T : Window, new()
        {
            Window wind = new T();
            wind.Show();
        }
        



    }

    
}

