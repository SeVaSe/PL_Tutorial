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
        //синтакс языка
        public static void SyntaxOsnClick()
        {
            Window wind = new Sintax_Osn_Page();
            wind.Show();
        }

        //переменные
        public static void PeremenOsnClick()
        {
            Window wind = new Peremen_Osn_Page();
            wind.Show();
        }

        //типы данных
        public static void TypeDateClick()
        {
            Window wind = new TypeDate_Osn_Page();
            wind.Show();
        }

        //консольный ввод и вывод
        public static void ConsolePrintInputClick()
        {
            Window wind = new ConsolePrintInput_Osn_Page();
            wind.Show();
        }

        //арифм операции
        public static void ArifmOperationClick()
        {
            Window wind = new Arifm_Osn_Page();
            wind.Show();
        }

        //преобразование типов
        public static void ConvertTypeClick()
        {
            Window wind = new ConvertType_Osn_Page();
            wind.Show();
        }

        //условные операции
        public static void UslovnVirazClick()
        {
            Window wind = new UslovnViraz();
            wind.Show();
        }

        //IF-конструкция
        public static void IfConstrClick()
        {
            Window wind = new IfConstruction_Osn_Page();
            wind.Show();
        }

        //цикл for
        public static void CycleForClick()
        {
            Window wind = new CycleFor_Osn_Page();
            wind.Show();
        }

        //цикл while
        public static void CycleWhileClick()
        {
            Window wind = new CycleWhile_Osn_Page();
            wind.Show();
        }

        //вложенность и выход из цикла
        public static void VlozhAndBreakCycle()
        {
            Window wind = new Break_Vlozh_Cycle();
            wind.Show();
        }

        //списки
        public static void ListClick()
        {
            Window wind = new List_Osn_Page();
            wind.Show();
        }

        //диапозоны
        public static void DiapozonClick()
        {
            Window wind = new Diapozon_Osn_Page();
            wind.Show();
        }

        //кортежи
        public static void TuplrClick()
        {
            Window wind = new Tuple_Osn_Page();
            wind.Show();
        }

        //словари
        public static void DictClick()
        {
            Window wind = new Dict_Osn_Page();
            wind.Show();
        }

        //множества
        public static void SetClick()
        {
            Window wind = new Set_Osn_Page();
            wind.Show();
        }

        //генератор списка
        public static void GeneratorListClick()
        {
            Window wind = new GeneratotList_Osn_Page();
            wind.Show();
        }

        //упаковка и распаковка
        public static void UpakovkaRapokovkaClick()
        {
            Window wind = new UpakovkaRaspakovka_Osn_Page();
            wind.Show();
        }

        //функции
        public static void FuncClick()
        {
            Window wind = new Function_Osn_Page();
            wind.Show();
        }

        //параметры функции
        public static void ParamFuncClick()
        {
            Window wind = new ParametrFunc_Osn_Page();
            wind.Show();
        }

        //return возращение результата функции
        public static void ReturnFuncClick()
        {
            Window wind = new ReturnFunc_Osn_Page();
            wind.Show();
        }

        //функция как тип
        public static void FuncAsTypleClick()
        {
            Window wind = new FuncAsType_Osn_Page();
            wind.Show();
        }

        //функция как параметр
        public static void FuncAsParamClick()
        {
            Window wind = new FuncAsParam_Osn_Page();
            wind.Show();
        }

        //функция как результат другой функции
        public static void FuncAsResultClick()
        {
            Window wind = new FuncAsResult_Osn_Page();
            wind.Show();
        }

        //лямбда
        public static void LamdaClick()
        {
            Window wind = new Lambda_Osn_Page();
            wind.Show();
        }

        //область видимости
        public static void OblatVidim()
        {
            Window wind = new OblastVidim_Osn_Page();
            wind.Show();
        }

        //замыкание
        public static void ZamikClick()
        {
            Window wind = new Zamik_Osn_Page();
            wind.Show();
        }

        //декораторы
        public static void DecoratorsClick()
        {
            Window wind = new Decorator_Osn_Page();
            wind.Show();
        }

        //ООП концепция
        public static void OOP_ConceptionsClick()
        {
            Window wind = new OOP_Conception();
            wind.Show();
        }



    }
}

