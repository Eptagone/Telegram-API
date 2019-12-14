//--------------------------------------------------------------------------------
// Author: Quetzal Rivera          Email: QuetzalDeveloper@outlook.com
// Project name: Telegram API            Date of creation: 13-12-2019
// Description: Library to access and interact with the Telegram Bot API.
// Review History:
// Creation: Creation   |   Date: 13-12-2019
// Description: Library creation. All commands are found
// and/or methods up to Bot API 4.4 published on July 29, 2019
// _______________________________________________________
//--------------------------------------------------------------------------------

namespace TelegramAPI
{
    /// <summary>Telegram Bot Client.</summary>
    public partial class BotClient
    {
        internal const string TelegramBotAPIUrl = "https://api.telegram.org/bot";
        /// <summary>Token granted by BotFather. Required to access the Telegram bot API.</summary>
        public string Token { get; set; }
        /// <summary>Initialize a Telegram Bot Client.</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API.</param>
        public BotClient(string accessToken) => Token = accessToken;
    }
}
