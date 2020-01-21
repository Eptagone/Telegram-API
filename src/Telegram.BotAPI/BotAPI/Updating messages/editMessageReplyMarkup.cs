// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
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
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var json_result = T.RPC<JsonElement>("editMessageReplyMarkup", args, options);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit only the reply markup of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static async Task<dynamic> EditMessageReplyMarkupAsync(this BotClient T, EditMessageReplyMarkup args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var json_result = await T.RPCA<JsonElement>("editMessageReplyMarkup", args, options).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
    }
}