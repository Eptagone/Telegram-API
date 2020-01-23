using System;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;

namespace Admin_bot_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new BotClient("<your token>");
            while(true){
                var updates = bot.GetUpdates();
            }
        }
    }
}
