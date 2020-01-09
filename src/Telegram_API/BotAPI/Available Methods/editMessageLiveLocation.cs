// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic EditMessageLiveLocation(this BotClient T, EditMessageLiveLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = T.RPC<JToken>("editMessageLiveLocation", args);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> EditMessageLiveLocationAsync(this BotClient T, EditMessageLiveLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = await T.RPCA<JToken>("editMessageLiveLocation", args).ConfigureAwait(true);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
    }
}