using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI;

using PL_Tutorial.Window_Menu;

namespace PL_Tutorial
{
    public class GptModel_Class
    {
        private const string APIkey = "твой API ключ";

        public async Task<string> GenerateText(string inputText)
        {
            OpenAIApi openAI = new OpenAIApi(APIkey);

            string[] prompt = new string[] { inputText };

            var completionRequest = new CompletionRequest
            {
                Model = "text-davinci-003",
                Prompt = prompt,
                MaxTokens = 100
            };

            var completionResponse = await openAI.Complete(completionRequest);
            string generatedText = completionResponse.Choices[0].Text.Trim();

            return generatedText;
        }
    }
}
