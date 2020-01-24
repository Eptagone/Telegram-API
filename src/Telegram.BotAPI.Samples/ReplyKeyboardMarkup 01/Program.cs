using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;

namespace ReplyKeyboardMarkup_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var bot = new BotClient("<your bot token>");
            while (true)
            {
                var updates = bot.GetUpdates();
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        switch (update.Type)
                        {
                            case UpdateType.Message:
                                if (update.Message.Text.Contains("/reply"))
                                {
                                    var keyboard = new ReplyKeyboardMarkup
                                    {
                                        Keyboard = new KeyboardButton[][]{
                                            new KeyboardButton[]{
                                                new KeyboardButton("Button 1"), //column 1 row 1
                                                new KeyboardButton("Button 2") //column 1 row 2
                                                },// column 1
                                            new KeyboardButton[]{
                                                new KeyboardButton("Button 3") //col 2 row 1
                                                } // column 2
                                        },
                                        Resize_keyboard = true
                                    };;
                                    bot.SendMessage(update.Message.Chat.Id, "new keyboard", reply_markup: keyboard);
                                }
                                if(update.Message.Text.Contains("/del")){
                                    bot.SendMessage(update.Message.Chat.Id, "remove reply keyboard", reply_markup: new ReplyKeyboardRemove());
                                }
                                break;
                        }
                    }
                    updates = bot.GetUpdates(offset: updates.Max(u => u.Update_id) + 1);
                }
            }
        }
    }
}
