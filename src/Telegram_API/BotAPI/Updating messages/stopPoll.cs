// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Updating_messages
{
    /// <summary>Updating messages</summary>
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static Available_Types.Poll StopPoll(this BotClient T, long chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Poll>("stopPoll", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id) });
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static Available_Types.Poll StopPoll(this BotClient T, string chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Poll>("stopPoll", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id) });
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="Available_Types.InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static Available_Types.Poll StopPoll(this BotClient T, long chat_id, uint message_id, Available_Types.InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Poll>("stopPoll", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id), new JProperty("reply_markup", reply_markup) });
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="Available_Types.InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static Available_Types.Poll StopPoll(this BotClient T, string chat_id, uint message_id, Available_Types.InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Poll>("stopPoll", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id), new JProperty("reply_markup", reply_markup) });
        }
    }
}
