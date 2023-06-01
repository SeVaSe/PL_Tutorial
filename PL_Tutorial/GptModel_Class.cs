using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using PL_Tutorial.Window_Menu;


namespace PL_Tutorial
{
    /*ПРОЕКТ GPT-ФУНКЦИЯ ПРИКРЫТ НА НЕОПРЕДЕЛЕННОЕ ВРЕМЯ, С СВЯЗИ С ТЕМ, ЧТО API КЛЮЧ, УТРАТИЛ ВРЕМЕННЫЙ ПЕРИОД И БОЛЬШЕ ПРИШЕЛ В НЕГОДНОСТЬ
НО ФУНКЦИЯ ОСТАНЕТСЯ В ДАННОМ ОКНЕ И ПРОДОЛЖИТ ВИСЕТЬ, ДО СКОРЫХ ВОЗМОЖНЫХ ИЗМЕНЕНИЙ В openAI*/

    public class GptModel_Class
    {
        public async static void Gpt_Work(TextBox TxtBox_Gpt_Zapr, TextBlock TxtBl_Vivod_Zapr)
        {
            OpenAIAPI api = new OpenAIAPI(new APIAuthentication("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"));
            string zapr = TxtBox_Gpt_Zapr.Text;
                
            var result = await api.Completions.CreateCompletionAsync(new CompletionRequest()
            {
                Model = Model.DavinciText,
                Temperature = 0.1,
                MaxTokens = 2000,
                Prompt = zapr,
            });
            var reply = result;
            TxtBl_Vivod_Zapr.Text = Convert.ToString(reply);
                
                
        }


        







    }
}
