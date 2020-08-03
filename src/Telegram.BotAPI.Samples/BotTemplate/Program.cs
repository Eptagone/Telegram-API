using System;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;

namespace BotTemplateSample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var client = new BotClient("<your bot token>");
            client.DeleteWebhook();
            var bot = new BotTemplate(client);
            bot.OnMessage += new EventHandler<UpdateEventArgs<Message>>(OnMessage);
            bot.OnException += new EventHandler<UpdateEventArgs<Exception>>(OnException);
            bot.OnBotException += new EventHandler<UpdateEventArgs<BotRequestException>>(OnBotException);
            bot.StartPollingAsync();
            Console.Read();
        }

        public static void OnMessage(object e, UpdateEventArgs<Message> eventArgs)
        {
            var template = e as BotTemplate;
            var message = eventArgs.EventParameter;
            //bot.SendChatAction(message.Chat.Id, ChatAction.Typing);
            eventArgs.Bot.SendMessage(message.Chat.Id, "Hello World!");
        }

        public static void OnException(object e, UpdateEventArgs<Exception> eventArgs)
        {
            var template = e as BotTemplate;
            Console.WriteLine(eventArgs.ToString());
        }
        public static void OnBotException(object e, UpdateEventArgs<BotRequestException> eventArgs)
        {
            var template = e as BotTemplate;
            var exp = eventArgs.EventParameter;
            Console.WriteLine($"BotException\nError Code: {exp.Error_code}\nMessage: {exp.Message}");
        }
    }
}
