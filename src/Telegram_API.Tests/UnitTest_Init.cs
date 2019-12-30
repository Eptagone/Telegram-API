// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI;

namespace Telegram_API.Tests
{
    public class Tools
    {
        /// <summary>Bot client client created from bot token for unit test.</summary>
        public static readonly BotClient bot = new BotClient("1039967130:AAGppcmLCGEzpjaiNQ8iq-hVNLhH6_P75GQ");
        /// <summary>Chat id for unit tests.</summary>
        public static readonly long chat_id = -339947707;
    }
}
