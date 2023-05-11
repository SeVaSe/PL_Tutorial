using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace PL_Tutorial.Window_Menu
{
    public partial class Window_Python : Window
    {
        // логика прокрутки всех элементов кнопок
        private ListBoxItem lastFoundItem = null;


        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string searchText = Txt_Box_Search.Text.ToLower();

                if (lastFoundItem != null)
                {
                    lastFoundItem.IsSelected = false;
                    lastFoundItem.Background = Brushes.Red;
                }

                bool itemFound = false;

                foreach (var item in Lst_Box_Osn.Items)
                {
                    ListBoxItem listBoxItem = item as ListBoxItem;
                    if (listBoxItem != null && listBoxItem.Content.ToString().ToLower().Contains(searchText))
                    {
                        listBoxItem.IsSelected = true;
                        listBoxItem.Background = Brushes.Yellow;
                        listBoxItem.Focus();
                        Lst_Box_Osn.ScrollIntoView(listBoxItem);
                        lastFoundItem = listBoxItem;
                        Txt_Box_Search.Focus();

                        itemFound = true;

                        break;
                    }
                }

                if (!itemFound)
                {
                    foreach (var item in Lst_OOP.Items)
                    {
                        ListBoxItem listBoxItem = item as ListBoxItem;
                        if (listBoxItem != null && listBoxItem.Content.ToString().ToLower().Contains(searchText))
                        {
                            listBoxItem.IsSelected = true;
                            listBoxItem.Background = Brushes.Yellow;
                            listBoxItem.Focus();
                            Lst_OOP.ScrollIntoView(listBoxItem);
                            lastFoundItem = listBoxItem;
                            Txt_Box_Search.Focus();

                            itemFound = true;

                            break;
                        }
                    }
                }

                if (!itemFound)
                {
                    // Обработка случая, когда элемент не был найден
                    // ...
                }
            }
        }








        /*private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (lastFoundItem != null && sender == lastFoundItem.Content)
            {
                lastFoundItem.Background = Brushes.Red; // устанавливаем оранжевый цвет фона для найденного элемента при наведении на него мыши
            }
        }*/
    }
}
