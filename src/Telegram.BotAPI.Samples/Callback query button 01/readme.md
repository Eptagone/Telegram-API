# Callback query button - Sample 01

## Description
.NET Core console app

Create a button with the /callback command
Pressing it edits the message, removing the button and typing new text.

## Preview
![hello world gif](/docs/media/samples/callback&#32;query&#32;button&#32;01.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Updating_messages;

namespace Callback_query_button_01
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
                        switch(update.Type){
                            case UpdateType.Message:
                                var message = update.Message;
                                if (message.Text.Contains("/callback"))
                                {
                                    var replyMarkup = new InlineKeyboardMarkup
                                    {
                                        Inline_keyboard = new InlineKeyboardButton[][]{
                                        new InlineKeyboardButton[]{
                                            InlineKeyboardButton.SetCallbackData("Callback", "callback_data")
                                            }
                                        }
                                    };
                                    bot.SendMessage(message.Chat.Id, "Message with callback data", reply_markup: replyMarkup);
                                }
                                break;
                            case UpdateType.Callback_query:
                                var callbackq = update.Callback_query;
                                bot.EditMessageText(new EditMessageTextArgs
                                {
                                    Chat_id = callbackq.Message.Chat.Id,
                                    Message_id = callbackq.Message.Message_id,
                                    Text = $"Click!\n\n{callbackq.Data}"
                                });
                                break;
                        }
                    }
                    updates = updates = bot.GetUpdates(offset: updates.Max(u => u.Update_id) + 1);
                }
            }
        }
    }
}
```