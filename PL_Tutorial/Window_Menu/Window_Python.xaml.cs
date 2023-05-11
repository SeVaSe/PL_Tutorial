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
    /// Логика взаимодействия для Window_Python.xaml
    /// </summary>
    public partial class Window_Python : Window
    {
        public Window_Python()
        {
            InitializeComponent();
        }


        //----------------КНОПКИ ОБРАБОТЧИКИ ПРИЛОЖЕНИЯ----------------
        //свернуть
        private void Svernut_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //назад
        private void Btn_Back_Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }


        //перетаскивание окна
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

        //GreenBox Библ
        private void Button_Green_Click(object sender, MouseButtonEventArgs e)
        {
            Window wind = new Windows_Page.Library();
            wind.Show();
            this.Close();
        }


        //PinkBox Фрейм
        private void Button_Pink_Click(object sender, MouseButtonEventArgs e)
        {
            Window wind = new Windows_Page.Frameworks();
            wind.Show();
            this.Close();
        }


        //WhiteBox Нейронки
        private void Button_White_Click(object sender, MouseButtonEventArgs e)
        {
            Window wind = new Windows_Page.AI_Neiron();
            wind.Show();
            this.Close();
        }

        //PurpleBox ДопФункции
        private void Button_Purple_Click(object sender, MouseButtonEventArgs e)
        {
            Window wind = new Windows_Page.Dop_Funcional();
            wind.Show();
            this.Close();
        }

        



        //----------------НАЖАТИЕ ОБРАБОТКИ КНОПОК В ListBox Основы языка----------------
        private void Btn_Osn_Print_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnOsnPrintClick();
        }

        private void Btn_Peremen_Type_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnPeremenTypeClick();
        }

        private void Btn_Console_In_Out_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnConsoleInOutClick();
        }

        private void Btn_Arifm_Operation_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnArifmOperation();
        }

        private void Btn_Uslovn_Viraz_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnUslovnViraz();
        }

        private void Btn_If_Constr_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnIFConsruction();
        }

        private void Btn_Cikli_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnCikli();
        }

        private void Btn_List_Page_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnListPage();
        }

        private void Btn_Func_Page_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.BtnFuncPage();
        }

        





        //------------------------------------------------------------------


        //----------------НАЖАТИЕ ОБРАБОТКИ КНОПОК В ListBox ООП-Питон----------------

        //------------------------------------------------------------------










        //------------------------------------------------------------------

    }
}
