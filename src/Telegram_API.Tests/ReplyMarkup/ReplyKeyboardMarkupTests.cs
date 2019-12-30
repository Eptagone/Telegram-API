// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Types;
using TelegramAPI.Available_Methods;
using Xunit;

namespace Telegram_API.Tests
{
    public class ReplyKeyboardMarkupTests
    {
        /// <summary>new Reply Keyboard 2 cols and 4 rows.</summary>
        [Fact]
        public void NewReplyKeyboard2CX4R()
        {
            var replykeyboard = new ReplyKeyboardMarkup
            {
                Keyboard = new KeyboardButton[][]
                {
                    new KeyboardButton[] { new KeyboardButton("R1C1"), new KeyboardButton("R1C2") }, //Row 1
                    new KeyboardButton[] { new KeyboardButton("R2C1"), new KeyboardButton("R2C2") }, //Row 2
                    new KeyboardButton[] { new KeyboardButton("R3C1"), new KeyboardButton("R3C2") }, //Row 3
                    new KeyboardButton[] { new KeyboardButton("R4C1"), new KeyboardButton("R4C2") } //Row 4
                }
            }; // New reply keyboard with 2 cols and 4 rows
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "ReplyKeyboard2x4",
                    Reply_markup = replykeyboard
                });
        }
        [Fact]
        public void RemoveKeyboardMarkup()
        {
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "Remove Reply Keyboard",
                    Reply_markup = new ReplyKeyboardRemove()
                });
            Assert.NotNull(message);
        }
    }
}
