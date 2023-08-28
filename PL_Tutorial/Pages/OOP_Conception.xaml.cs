using PL_Tutorial.Window_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для OOP_Conception.xaml
    /// </summary>
    public partial class OOP_Conception : Window
    {
        public OOP_Conception()
        {
            InitializeComponent();
            Control_Class wind = new Control_Class(this);

            btn_close.Click += wind.close_cl;
            btn_svernut.Click += wind.minimazed_cl;
            btn_perezapusk.Click += (sender, e) => wind.perezapusk_cl(new OOP_Conception());
            btn_back.Click += wind.back_out_cl;
            br_up.MouseLeftButtonDown += wind.Window_MouseLeftButtonDown;
            br_up.MouseMove += wind.Window_MouseMove;





        }



        

        

        
        


    }
}
