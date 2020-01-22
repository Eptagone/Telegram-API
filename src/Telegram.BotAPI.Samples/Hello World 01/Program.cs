using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;

namespace Hello_World_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var bot = new BotClient("<your bot token>");
            while(true){
                var updates = bot.GetUpdates();
                if(updates.Length > 0){
                    foreach(var update in updates){
                        if(update.Type == UpdateType.Message){
                            var message = update.Message;
                            //bot.SendChatAction(message.Chat.Id, "typing");
                            bot.SendMessage(message.Chat.Id, "Hello World!");
                        }
                    }
                    updates = bot.GetUpdates(new GetUpdatesArgs { Offset = updates.Max(u => u.Update_id) + 1 });
                }
            }
        }
    }
}
