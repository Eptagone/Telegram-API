﻿#region AUTHOR
//--------------------------------------------------------------------------
// @author: Quetzal Rivera          @email: QuetzalDeveloper@outlook.com
// Project name: Telegram API       Date of creation: 13-12-2019
// Description: Library to access and interact with the Telegram Bot API.
// Review History:
// Creation: Creation   |   Date: 13-12-2019
// Description: Library creation. All commands are found
// and/or methods up to Bot API 4.4 published on July 29, 2019
// ________________________________________________________________________
//--------------------------------------------------------------------------
#endregion

namespace Telegram.BotAPI
{
    /// <summary>Telegram Bot Client.</summary>
    public sealed partial class BotClient
    {
        /// <summary>Bot base url for call methods.</summary>
        public static readonly string BaseBotAPIUrl = "https://api.telegram.org/bot";
        /// <summary>Bot base url for file download.</summary>
        public static readonly string NaseFilesUrl = "https://api.telegram.org/file/bot";
        /// <summary>Token granted by BotFather. Required to access the Telegram bot API.</summary>
        public string Token { get; set; }
        /// <summary>Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/></summary>
        public bool IgnoreBotExceptions { get; set; }
        /// <summary>Initialize a Telegram Bot Client.</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API.</param>
        public BotClient(string accessToken) => Token = accessToken;
    }
}
