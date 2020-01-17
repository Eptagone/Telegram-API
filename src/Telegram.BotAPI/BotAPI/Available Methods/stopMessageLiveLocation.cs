// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic StopMessageLiveLocation(this BotClient T, StopMessageLiveLocationArgs args = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            JToken result;
            if(args == default)
                result = T.RPC<JToken>("stopMessageLiveLocation");
            else
                result = T.RPC<JToken>("stopMessageLiveLocation", args);
            if (result.Type == JTokenType.Object)
                return result.ToObject<Message>();
            else
                return result.ToObject<bool>();
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> StopMessageLiveLocationAsync(this BotClient T, StopMessageLiveLocationArgs args = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            JToken result;
            if(args == default)
                result = await T.RPCA<JToken>("stopMessageLiveLocation").ConfigureAwait(true);
            else
                result = await T.RPCA<JToken>("stopMessageLiveLocation", args).ConfigureAwait(true);
            if (result.Type == JTokenType.Object)
                return result.ToObject<Message>();
            else
                return result.ToObject<bool>();
        }
    }
}
