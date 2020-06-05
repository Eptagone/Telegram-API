// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Tests
{
    public static class Settings
    {
        /// <summary>Bot token for bot api testing.</summary>
        public static BotClient Bot => new BotClient(BotToken);
        /// <summary>Bot token for bot api testing.</summary>
        public const string BotToken = "956001060:AAGrtUYMFn4lQjlfqxmBYdNvuqfPOHEG-Ps";
        /// <summary>Unique Id of private chat for bot api testing. Can be the user id.</summary>
        public const int PChatId = 418909573;
        /// <summary>Unique Id of group chat for bot api testing. Can be the user id.</summary>
        public const int ChatId = default;
        // public const string ChatId = default;
        /// <summary>Unique Id of channel chat for bot api testing. Can be the user id.</summary>
        public const int ChannelId = default;
        // public const string ChannelId = default;
    }
}
