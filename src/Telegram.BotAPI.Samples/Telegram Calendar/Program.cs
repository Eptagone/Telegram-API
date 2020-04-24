// By Quetzal Rivera

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Updating_messages;

namespace Telegram_Calendar
{
    class Program
    {
        private static BotClient bot = new BotClient("<yout bot token>");
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var days = new Month(MonthName.April, 2020);
            var updates = bot.GetUpdates();
            while (true)
            {
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        switch(update.Type){
                            case UpdateType.Message:
                                OnMessage(update.Message);
                                break;
                            case UpdateType.Callback_query:
                                OnCallbackQuery(update.Callback_query);
                                break;
                        }
                    }
                    updates = bot.GetUpdates(offset: updates.Max(u => u.Update_id) + 1);
                }
                else{
                    updates = bot.GetUpdates();
                }
            }
        }
        private static void OnMessage(Message message)
        {
            if (message.Text.Contains("/calendar"))
            {
                var rm = new InlineKeyboardMarkup
                {
                    Inline_keyboard = CreateCalendar(2020)
                };
                bot.SendMessage(message.Chat.Id, "🗓 <b>Telegram Bot Calendar</b> 🗓", parse_mode: ParseMode.HTML, reply_markup: rm);
            }
        }
        private static void OnCallbackQuery(CallbackQuery query)
        {
            var cbargs = query.Data.Split(' ');
            switch (cbargs[0])
            {
                case "month":
                    var month = new Month((MonthName)Enum.Parse(typeof(MonthName), cbargs[2]), uint.Parse(cbargs[1]));
                    var mkeyboard = new InlineKeyboardMarkup
                    {
                        Inline_keyboard = CreateCalendar(month)
                    };
                    bot.EditMessageReplyMarkup(new EditMessageReplyMarkup
                    {
                        Chat_id = query.Message.Chat.Id,
                        Message_id = query.Message.Message_id,
                        Reply_markup = mkeyboard
                    });
                    break;
                case "year":
                    var ykeyboard = new InlineKeyboardMarkup
                    {
                        Inline_keyboard = CreateCalendar(uint.Parse(cbargs[1]))
                    };
                    bot.EditMessageReplyMarkup(new EditMessageReplyMarkup
                    {
                        Chat_id = query.Message.Chat.Id,
                        Message_id = query.Message.Message_id,
                        Reply_markup = ykeyboard
                    });
                    break;
                default:
                    bot.AnswerCallbackQuery(new AnswerCallbackQueryArgs
                    {
                        Callback_query_id = query.Id,
                        Text = query.Data,
                        Show_alert = true
                    });
                    break;
            }

        }
        public static InlineKeyboardButton[][] CreateCalendar(Month mon)
        {
            var calendar = new InlineKeyboardButton[mon.Weeks + 3][];
            var pos = 0;
            calendar[0] = new InlineKeyboardButton[1]
            {
                InlineKeyboardButton.SetCallbackData($"{mon.Name.ToString()} {mon.Year.ToString()}", $"year {mon.Year.ToString()}")
            };
            var days = new[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
            calendar[1] = new InlineKeyboardButton[7];
            for (int i = 0; i < 7; i++)
            {
                calendar[1][i] = InlineKeyboardButton.SetCallbackData(days[i], $"{((DayName)i).ToString()}");
            }
            for (int i = 2; i < mon.Weeks + 2; i++)
            {
                calendar[i] = new InlineKeyboardButton[7];
                for (int j = 0; j < 7; j++)
                {
                    if (pos < mon.Days.Length)
                    {
                        if ((int)mon.Days[pos].Name == j)
                        {
                            calendar[i][j] = InlineKeyboardButton.SetCallbackData($"{mon.Days[pos].Number.ToString()}", $"{mon.Days[pos].Name.ToString()}, {mon.Name.ToString()} {mon.Days[pos].Number.ToString()}");
                            pos++;
                        }
                        else
                        {
                            calendar[i][j] = InlineKeyboardButton.SetCallbackData("*", "Empty day");
                        }
                    }
                    else
                    {
                        calendar[i][j] = InlineKeyboardButton.SetCallbackData("*", "Empty day");
                    }
                }
            }
            calendar[calendar.Length - 1] = new InlineKeyboardButton[2];
            var previousmonth = mon.Name == MonthName.January ? MonthName.December : mon.Name - 1;
            var nextmonth = mon.Name == MonthName.December ? MonthName.January : mon.Name + 1;
            var previousyear = previousmonth == MonthName.December ? mon.Year - 1 : mon.Year;
            var nextyear = nextmonth == MonthName.January ? mon.Year + 1 : mon.Year;
            calendar[calendar.Length - 1][0] = InlineKeyboardButton.SetCallbackData($"{previousmonth.ToString()}", $"month {previousyear.ToString()} {((ushort)previousmonth).ToString()}");
            calendar[calendar.Length - 1][1] = InlineKeyboardButton.SetCallbackData($"{nextmonth.ToString()}", $"month {nextyear.ToString()} {((ushort)nextmonth).ToString()}");
            return calendar;
        }
        public static InlineKeyboardButton[][] CreateCalendar(uint year)
        {
            var keyboard = new InlineKeyboardButton[6][];
            keyboard[0] = new InlineKeyboardButton[1]{
                InlineKeyboardButton.SetCallbackData($"{year.ToString()}", $"Year {year.ToString()}")
            };
            for (int i = 1, n = 0; i < 5; i++)
            {
                keyboard[i] = new InlineKeyboardButton[3];
                for (int j = 0; j < 3; j++, n++)
                {
                    var month = (MonthName)n;
                    keyboard[i][j] = new InlineKeyboardButton
                    {
                        Text = $"{month.ToString()}",
                        Callback_data = $"month {year.ToString()} {n.ToString()}"
                    };
                }
            }
            keyboard[5] = new InlineKeyboardButton[2]{
                InlineKeyboardButton.SetCallbackData($"{(year - 1).ToString()}",$"year {(year - 1).ToString()}"),
                InlineKeyboardButton.SetCallbackData($"{(year + 1).ToString()}",$"year {(year + 1).ToString()}")
            };
            return keyboard;
        }
    }
}
