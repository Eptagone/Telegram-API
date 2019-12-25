// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        public static dynamic StopMessageLiveLocation(this BotClient T)
        {
            var json_result = T.RPC<JValue>("stopMessageLiveLocation");
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Available_Types.Message>();
            else
                return json_result.ToObject<bool>();
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic StopMessageLiveLocation(this BotClient T, StopMessageLiveLocationArgs args = null)
        {
            var json_result = T.RPC<JValue>("stopMessageLiveLocation", args);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Available_Types.Message>();
            else
                return json_result.ToObject<bool>();
        }
    }
}
