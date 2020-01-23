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
            var bot = new BotClient("<bot token>");
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
                                        Reply_to_message_id = update.Message.Message_id,
                                        Question = "¿2 + 5?",
                                        Options = new string[]{
                                            "6", "7", "5", "-4"
                                        },
                                        Type = "quiz",
                                        Correct_option_id = 1
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
