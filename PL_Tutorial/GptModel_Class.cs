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
    public class GptModel_Class
    {
        public async static void Gpt_Work(TextBox TxtBox_Gpt_Zapr, TextBlock TxtBl_Vivod_Zapr)
        {
            OpenAIAPI api = new OpenAIAPI(new APIAuthentication("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"));
            var chat = api.Chat.CreateConversation();

            chat.AppendUserInput(TxtBox_Gpt_Zapr.Text);


            string response = await chat.GetResponseFromChatbotAsync();
            TxtBl_Vivod_Zapr.Text = response;
        }


        /*public async static void Gpt_Work(TextBox TxtBox_Gpt_Zapr, TextBlock TxtBl_Vivod_Zapr)
        {

            async Task StreamCompletionAsync(CompletionRequest request, Action<CompletionResult> resultHandler)
            {
                OpenAIAPI api = new OpenAIAPI(new APIAuthentication("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", ""));
                await api.Completions.StreamCompletionAsync(
                new CompletionRequest("My name is Roger and I am a principal software engineer at Salesforce.  This is my resume:", Model.DavinciText, 200, 0.5, presencePenalty: 0.1, frequencyPenalty: 0.1),
                res => TxtBl_Vivod_Zapr.Text += res.ToString());
            }

            // for example
            
        }*/







    }
}
