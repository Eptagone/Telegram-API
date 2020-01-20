// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Games
{
    public static partial class GamesMethods
    {
        ///<summary>Use this method to set the score of the specified user in a game. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</summary>
        ///<param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic SetGameScore(this BotClient T, SetGameScoreArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_message = T.RPC<JsonElement>("setGameScore", args);
            if (json_message.ValueKind == JsonValueKind.Object)
                return json_message.ToObject<Message>();
            else
                return json_message.GetBoolean();
        }
        ///<summary>Use this method to set the score of the specified user in a game. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</summary>
        ///<param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> SetGameScoreAsync(this BotClient T, SetGameScoreArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_message = await T.RPCA<JsonElement>("setGameScore", args).ConfigureAwait(false);
            if (json_message.ValueKind == JsonValueKind.Object)
                return json_message.ToObject<Message>();
            else
                return json_message.GetBoolean();
        }
    }
}
