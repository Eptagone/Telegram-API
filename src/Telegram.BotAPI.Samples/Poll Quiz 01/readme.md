# Poll Quiz - Sample 01

## Description
.NET Core console app

Create a quiz from the new polls 2.0

## Preview
![hello world gif](/docs/media/samples/quiz&#32;01.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Getting_updates;

namespace Poll_Quiz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var bot = new BotClient("<yout bot token>");
            while(true){
                var updates = bot.GetUpdates();
                if(updates.Length > 0){
                    foreach(var update in updates){
                        switch(update.Type){
                            case UpdateType.Message:
                                if(update.Message.Text.Contains("/quiz")){
                                    bot.SendPoll(new SendPollArgs
                                    {
                                        Chat_id = update.Message.Chat.Id,
                                        Question = "¿5 + 5?",
                                        Options = new string[]{
                                            "56", "7", "10", "-4"
                                        },
                                        Type = "quiz",
                                        Correct_option_id = 2
                                    });
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
```