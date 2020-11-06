#region AUTHOR
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

using System;

namespace Telegram.BotAPI
{
    /// <summary>Telegram Bot Client.</summary>
    public sealed partial class BotClient
    {
        /// <summary>Bot base url for download files. {0} = BotToken, {1} = FilePath</summary>
        public const string BaseFilesUrl = "https://api.telegram.org/file/bot{0}/{1}";
        /// <summary>Token granted by BotFather. Required to access the Telegram bot API.</summary>
        public string Token { get; set; }
        /// <summary>Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/></summary>
        public bool IgnoreBotExceptions { get; set; }
        /// <summary>Initialize a Telegram Bot Client.</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API.</param>
        /// <exception cref="ArgumentNullException">Thrown when accessToken is null.</exception>
        public BotClient(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                throw new ArgumentNullException(nameof(accessToken));
            }

            Token = accessToken;
            if (Client == default)
            {
                SetHttpClient();
            }
        }
    }
}
