// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Tests
{
    /// <summary>Settings for testing</summary>
    public static class Settings
    {
        /// <summary>Bot token for bot api testing.</summary>
        public static BotClient Bot => new BotClient(BotToken);
        /// <summary>Bot token for bot api testing.</summary>
        public const string BotToken = "<botToken>";
        /// <summary>Unique Id of private chat for bot api testing. Can be the user id.</summary>
        public const int PChatId = 0;
        /// <summary>Unique Id of group chat for bot api testing. Can be the user id.</summary>
        public const int ChatId = default;
        // public const string ChatId = default;
        /// <summary>Unique Id of channel chat for bot api testing. Can be the user id.</summary>
        public const int ChannelId = default;
        // public const string ChannelId = default;
        /// <summary>Unique photo file id.</summary>
        public const string PhotoFileId = "<photoFileId>";
        /// <summary>Unique video file id.</summary>
        public const string VideoFileId = "<videoFileId>";
        /// <summary>Unique document file id.</summary>
        public const string DocFileId = "<docFileId>";
        /// <summary>Invalid File id.</summary>
        public const string InvalidFileId = "null";
    }
}
