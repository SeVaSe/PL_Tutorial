using PL_Tutorial.Pages;
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
using System.Windows.Media.Animation;
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

        //перезапуск
        private void Perezapusk_Click(object sender, RoutedEventArgs e)
        {
            Window wind = new Window_Python();
            this.Close();
            wind.Show();
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
        private void Btn_Sintax_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.SyntaxOsnClick();
            this.Close();
        }

        private void Btn_Peremen_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.PeremenOsnClick();
            this.Close();
        }

        private void Btn_TypeDate_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.TypeDateClick();
            this.Close();
        }

        private void Btn_ConsolePrIn_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ConsolePrintInputClick();
            this.Close();
        }

        private void Btn_Arifm_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ArifmOperationClick();
            this.Close();
        }

        private void Btn_ConvertType_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ConvertTypeClick();
            this.Close();
        }

        private void Btn_UslovnViraz_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.UslovnVirazClick();
            this.Close();
        }

        private void Btn_IfConstr_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.IfConstrClick();
            this.Close();
        }








        private void Btn_For_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.CycleForClick();
            this.Close();
        }

        private void Btn_While_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.CycleWhileClick();
            this.Close();
        }

        private void Btn_Vlozh_Break_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.VlozhAndBreakCycle();
            this.Close();
        }

        private void Btn_List_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ListClick();
            this.Close();
        }

        private void Btn_Diapos_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.DiapozonClick();
            this.Close();
        }

        private void Btn_Tuple_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.TuplrClick();
            this.Close();
        }

        private void Btn_Dict_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.DictClick();
            this.Close();
        }

        private void Btn_Set_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.SetClick();
            this.Close();
        }

        private void Btn_Generator_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.GeneratorListClick();
            this.Close();
        }

        private void Btn_Upakovka_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.UpakovkaRapokovkaClick();
            this.Close();
        }

        private void Btn_Func_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.FuncClick();
            this.Close();
        }

        private void Btn_ParamFunc_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ParamFuncClick();
            this.Close();
        }

        private void Btn_ReturnFunc_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ReturnFuncClick();
            this.Close();
        }

        private void Btn_FuncAsType_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.FuncAsTypleClick();
            this.Close();
        }

        private void Btn_FuncAsParam_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.FuncAsParamClick();
            this.Close();
        }

        private void Btn_ResultReturn_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.FuncAsResultClick();
            this.Close();
        }

        private void Btn_Lymda_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.LamdaClick();
            this.Close();
        }

        private void Btn_OblastVid_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.OblatVidim();
            this.Close();
        }

        private void Btn_Zamik_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.ZamikClick();
            this.Close();
        }

        private void Btn_Decorator_Click(object sender, RoutedEventArgs e)
        {
            Osn_Button_Class.DecoratorsClick();
            this.Close();
        }



        //------------------------------------------------------------------


        //----------------НАЖАТИЕ ОБРАБОТКИ КНОПОК В ListBox ООП-Питон----------------

        //------------------------------------------------------------------










        //------------------------------------------------------------------

    }
}
