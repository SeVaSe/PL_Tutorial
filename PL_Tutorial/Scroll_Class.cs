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
                string searchText = Txt_Box_Search.Text.ToLower(); // получаем введенный текст из TextBox и приводим к нижнему регистру

                // снимаем выделение и изменяем фоновый цвет с предыдущего найденного элемента
                if (lastFoundItem != null)
                {
                    lastFoundItem.IsSelected = false;
                    lastFoundItem.Background = Brushes.Red;
                }

                bool flagItemFound = false;

                foreach (var item in Lst_Box_Osn.Items)
                {
                    ListBoxItem listBoxItem = item as ListBoxItem;
                    if (listBoxItem != null && listBoxItem.Content.ToString().ToLower().Contains(searchText))
                    {
                        listBoxItem.IsSelected = true; // выделяем найденный элемент в ListBox
                        listBoxItem.Background = Brushes.Yellow; // устанавливаем желтый цвет фона для найденного элемента
                        listBoxItem.Focus(); // устанавливаем фокус на найденный элемент, чтобы обновить его внешний вид
                        Lst_Box_Osn.ScrollIntoView(listBoxItem); // прокручиваем ListBox к найденному элементу
                        lastFoundItem = listBoxItem; // сохраняем ссылку на найденный элемент
                        Txt_Box_Search.Focus(); // устанавливаем фокус на Txt_Box_Search

                        flagItemFound = true;
                        
                        break;
                    }
                }

               
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
                        Txt_Box_Search.Focus(); // устанавливаем фокус на Txt_Box_Search

                        flagItemFound = true;

                        break;
                    }
                }

                if (flagItemFound == false)
                {
                    Txt_Box_Search.Clear();
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
