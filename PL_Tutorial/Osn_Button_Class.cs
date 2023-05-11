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
        public static void BtnOsnPrintClick()
        {
            Window wind = new Window();
            wind.Content = new Pages.osn_print();
            wind.WindowState = WindowState.Maximized;
            wind.WindowStyle = WindowStyle.None;
            wind.Show();
        }


        public static void BtnPeremenTypeClick()
        {
            Window wind = new Window();
            wind.Content = new Pages.Peremen_type();
            wind.WindowState = WindowState.Maximized;
            wind.WindowStyle = WindowStyle.None;
            wind.Show();
        }

        public static void BtnConsoleInOutClick()
        {
            Window wind = new Window();
            wind.Content = new Pages.Console_Input_Out();
            wind.Show();
        }

        public static void BtnArifmOperation()
        {
            Window wind = new Window();
            wind.Content = new Pages.Arifm_Operation();
            wind.Show();
        }

        public static void BtnUslovnViraz()
        {
            Window wind = new Window();
            wind.Content = new Pages.Uslovn_Viraz();
            wind.Show();
        }

        public static void BtnIFConsruction()
        {
            Window wind = new Window();
            wind.Content = new Pages.If_Construcia();
            wind.Show();
        }

        public static void BtnCikli()
        {
            Window wind = new Window();
            wind.Content = new Pages.Cikli();
            wind.Show();
        }

        public static void BtnListPage()
        {
            Window wind = new Window();
            wind.Content = new Pages.List_page();
            wind.Show();
        }

        public static void BtnFuncPage()
        {
            Window wind = new Window();
            wind.Content = new Pages.Func_Page();
            wind.Show();
        }




        /*//Обработчик перехода на другое окно
        public static void BtnLibrary_Wind()
        {
            Window wind = new Library();
            wind.Show();
        }

        public static void BtnFrameworks_Wind()
        {
            Window wind = new Frameworks();
            wind.Show();
        }

        public static void BtnAiNeiron()
        {
            Window wind = new AI_Neiron();
            wind.Show();
        }*/
    }
}

