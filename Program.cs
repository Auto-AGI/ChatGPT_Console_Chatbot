using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI_API.Completions;

namespace ChatGPT_Console_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and intialize input variable with value of empty string
            string input = "";
            //while loop that run untill user enter exit
            while (input != "exit")
            {

                input = Console.ReadLine();
                //create openai instance or object
                var openai = new OpenAIAPI("<Add Your OPENAI API Key Here");
                // completion request and set the properties of it
                var completion_request = new CompletionRequest();
                completion_request.Prompt = input;
                completion_request.Model = OpenAI_API.Models.Model.DavinciText;
                completion_request.MaxTokens = 80;
                var completion = openai.Completions.CreateCompletionsAsync(completion_request, 1);
                //foreach loop to iterate over the values
                foreach (var comp in completion.Result.Completions)
                {
                    Console.Write(comp.Text + "\n");
                }
               
            }
            Console.WriteLine("You entered Exit, App is Closing");
        }
    }
}
