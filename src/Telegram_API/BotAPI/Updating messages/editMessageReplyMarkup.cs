// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Updating_messages
{
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to edit only the reply markup of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static dynamic EditMessageReplyMarkup(this BotClient T, EditMessageReplyMarkup args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = T.RPC<JToken>("editMessageReplyMarkup", args);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
        /// <summary>Use this method to edit only the reply markup of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static async Task<dynamic> EditMessageReplyMarkupAsync(this BotClient T, EditMessageReplyMarkup args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = await T.RPCA<JToken>("editMessageReplyMarkup", args).ConfigureAwait(true);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
    }
}