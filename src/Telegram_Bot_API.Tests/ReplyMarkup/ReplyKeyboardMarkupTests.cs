﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Methods;
using TelegramAPI.Available_Types;
using Xunit;

namespace TelegramBotAPI.Tests
{
    public sealed partial class ReplyMarkupTests
    {
        [Fact]
        [Trait("Keyboard 2 x 4", "ReplyKeyboardMarkup")]
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
            var message = bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = chat_id,
                    Text = "ReplyKeyboard2x4",
                    Reply_markup = replykeyboard
                });
        }
        [Fact]
        [Trait("Remove Keyboard", "ReplyKeyboardMarkup")]
        public void RemoveKeyboardMarkup()
        {
            var message = bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = chat_id,
                    Text = "Remove Reply Keyboard",
                    Reply_markup = new ReplyKeyboardRemove()
                });
            Assert.NotNull(message);
        }
    }
}