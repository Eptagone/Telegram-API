// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to edit captions of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic EditMessageCaption(this BotClient T, EditMessageCaptionArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = T.RPC<JToken>("editMessageCaption", args);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
        /// <summary>Use this method to edit captions of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> EditMessageCaptionAsync(this BotClient T, EditMessageCaptionArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var json_result = await T.RPCA<JToken>("editMessageCaption", args).ConfigureAwait(true);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.ToObject<bool>();
        }
    }
}