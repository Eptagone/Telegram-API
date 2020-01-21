// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic StopMessageLiveLocation(this BotClient T, StopMessageLiveLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var result = T.RPC<JsonElement>("stopMessageLiveLocation", args, options);
            if (result.ValueKind == JsonValueKind.Object)
                return result.ToObject<Message>();
            else
                return result.GetBoolean();
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> StopMessageLiveLocationAsync(this BotClient T, StopMessageLiveLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var result = await T.RPCA<JsonElement>("stopMessageLiveLocation", args, options).ConfigureAwait(false);
            if (result.ValueKind == JsonValueKind.Object)
                return result.ToObject<Message>();
            else
                return result.GetBoolean();
        }
    }
}
