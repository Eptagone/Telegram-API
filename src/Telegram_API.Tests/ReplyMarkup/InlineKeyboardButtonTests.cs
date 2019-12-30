// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI;
using TelegramAPI.Available_Types;
using TelegramAPI.Available_Methods;
using Xunit;
using Xunit.Abstractions;

namespace Telegram_API.Tests
{
    public class InlineKeyboardButtonTests
    {
        private readonly ITestOutputHelper output;
        public InlineKeyboardButtonTests(ITestOutputHelper outputHelper) => output = outputHelper;
        [Fact]
        public void NewInlineKeyboardButtonUrl()
        {
            var inlinekeyboard = new InlineKeyboardMarkup()
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[]{ new InlineKeyboardButton { Text = "URL", Url = "https://core.telegram.org/bots/api#inlinekeyboardmarkup" } }
                }
            };
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "New inline keyboard button url Test",
                    Reply_markup = inlinekeyboard
                });
        }
        [Fact]
        public void NewInlineKeyboardButtonCallback()
        {
            var inlinekeyboard = new InlineKeyboardMarkup()
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[]{ new InlineKeyboardButton { Text = "Callback", Callback_data = "callback_command" } }
                }
            };
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "New inline keyboard button callback Test",
                    Reply_markup = inlinekeyboard
                });
        }
        [Fact]
        public void NewInlineKeyboardButtonSwitchInlineQuery()
        {
            var inlinekeyboard = new InlineKeyboardMarkup()
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[]{ new InlineKeyboardButton { Text = "Switch Inline Query", Switch_inline_query = "inline_args" } }
                }
            };
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "New inline keyboard button switch inline query Test",
                    Reply_markup = inlinekeyboard
                });
            Assert.NotNull(message);
        }
        [Fact]
        public void NewInlineKeyboardButtonSwitchInlineQueryCurrentChat()
        {
            var inlinekeyboard = new InlineKeyboardMarkup()
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[]{ new InlineKeyboardButton { Text = "Switch Inline Query Current Chat", Switch_inline_query_current_chat = "inline_args" } }
                }
            };
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "New inline keyboard button switch inline query current Test",
                    Reply_markup = inlinekeyboard
                });
            Assert.NotNull(message);
        }
        [Fact]
        public void NewInlineKeyboardButtonLoginUrl()
        {
            var inlinekeyboard = new InlineKeyboardMarkup()
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[]{
                        new InlineKeyboardButton {
                            Text = "Login Url", Login_url = new LoginUrl {  Url = "https://example.com/login" } //Change this domain to your url
                        }
                    }
                }
            };
            try
            {
                var message = Tools.bot.SendMessage(
                    new SendMessageArgs
                    {
                        Chat_id = Tools.chat_id,
                        Text = "New inline keyboard button login url Test",
                        Reply_markup = inlinekeyboard
                    });
                output.WriteLine(message.Text);
            }catch(BotRequestException exp) //To avoid the exception it is necessary to set the domain for your bot with BotFather
            {
                Assert.NotNull(exp);
                string expmessage = exp.Description;
                output.WriteLine("Login Url => BotRequestException: {0}", expmessage);
            }
        }
        /// <summary>New InlineKeyboard 3 cols, 1 row, 2 rows and 3 rows.</summary>
        [Fact]
        public void NewInlineKeyboardMix()
        {
            var replykeyboard = new InlineKeyboardMarkup
            {
                Inline_keyboard = new InlineKeyboardButton[][]
                {
                    new InlineKeyboardButton[] {
                        new InlineKeyboardButton { Text = "R1C1 URL", Url = "https://core.telegram.org/bots/api#inlinekeyboardmarkup"}
                    }, //Row 1, 1 col
                    new InlineKeyboardButton[] {
                        new InlineKeyboardButton { Text = "R2C1 switch", Switch_inline_query = "inline_search" },
                        new InlineKeyboardButton { Text = "R2C2 switchc", Switch_inline_query_current_chat = "inline_search"}
                    }, //Row 2, 3 cols
                    new InlineKeyboardButton[] {
                        //You'll be able to receive these callback queries in an Update
                        new InlineKeyboardButton { Text = "R2C1 callback", Callback_data = "command1" }, 
                        new InlineKeyboardButton { Text = "R3C2 callback", Callback_data = "command2"},
                        new InlineKeyboardButton { Text = "R3C3 callback", Callback_data = "command3"}
                    } //Row 3
                }
            }; // New reply keyboard with 2 cols and 4 rows
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "InlineKeyboardMarkup Test. 3 cols, 1 row, 2 rows and 3 rows.",
                    Reply_markup = replykeyboard
                });
        }
    }
}
