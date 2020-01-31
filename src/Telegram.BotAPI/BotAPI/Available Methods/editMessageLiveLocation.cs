// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
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
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var json_result = T.RPC<JsonElement>("editMessageLiveLocation", args);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Required if inline_message_id is not specified. Identifier of the sent message.</param>
        /// <param name="inline_message_id">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
        /// <param name="latitude">Latitude of new location.</param>
        /// <param name="longitude">Longitude of new location.</param>
        /// <param name="reply_markup">Optional. A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</param>
        public static dynamic EditMessageLiveLocation(this BotClient T, [Optional] long chat_id, [Optional] uint message_id, [Optional] string inline_message_id, float latitude, float longitude, [Optional] InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new EditMessageLiveLocationArgs
            {
                Latitude = latitude,
                Longitude = longitude
            };
            if (chat_id != default)
                args.Chat_id = chat_id;
            if (message_id != default)
                args.Message_id = message_id;
            if (inline_message_id != default)
                args.Inline_message_id = inline_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            var json_result = T.RPC<JsonElement>("editMessageLiveLocation", args);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Required if inline_message_id is not specified. Identifier of the sent message.</param>
        /// <param name="inline_message_id">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
        /// <param name="latitude">Latitude of new location.</param>
        /// <param name="longitude">Longitude of new location.</param>
        /// <param name="reply_markup">Optional. A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</param>
        public static dynamic EditMessageLiveLocation(this BotClient T, [Optional] string chat_id, [Optional] uint message_id, [Optional] string inline_message_id, float latitude, float longitude, [Optional] InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new EditMessageLiveLocationArgs
            {
                Latitude = latitude,
                Longitude = longitude
            };
            if (chat_id != default)
                args.Chat_id = chat_id;
            if (message_id != default)
                args.Message_id = message_id;
            if (inline_message_id != default)
                args.Inline_message_id = inline_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            var json_result = T.RPC<JsonElement>("editMessageLiveLocation", args);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<dynamic> EditMessageLiveLocationAsync(this BotClient T, EditMessageLiveLocationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var json_result = await T.RPCA<JsonElement>("editMessageLiveLocation", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Required if inline_message_id is not specified. Identifier of the sent message.</param>
        /// <param name="inline_message_id">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
        /// <param name="latitude">Latitude of new location.</param>
        /// <param name="longitude">Longitude of new location.</param>
        /// <param name="reply_markup">Optional. A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<dynamic> EditMessageLiveLocationAsync(this BotClient T, [Optional] long chat_id, [Optional] uint message_id, [Optional] string inline_message_id, float latitude, float longitude, [Optional] InlineKeyboardMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new EditMessageLiveLocationArgs
            {
                Latitude = latitude,
                Longitude = longitude
            };
            if (chat_id != default)
                args.Chat_id = chat_id;
            if (message_id != default)
                args.Message_id = message_id;
            if (inline_message_id != default)
                args.Inline_message_id = inline_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            var json_result = await T.RPCA<JsonElement>("editMessageLiveLocation", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Required if inline_message_id is not specified. Identifier of the sent message.</param>
        /// <param name="inline_message_id">Required if chat_id and message_id are not specified. Identifier of the inline message.</param>
        /// <param name="latitude">Latitude of new location.</param>
        /// <param name="longitude">Longitude of new location.</param>
        /// <param name="reply_markup">Optional. A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<dynamic> EditMessageLiveLocationAsync(this BotClient T, [Optional] string chat_id, [Optional] uint message_id, [Optional] string inline_message_id, float latitude, float longitude, [Optional] InlineKeyboardMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new EditMessageLiveLocationArgs
            {
                Latitude = latitude,
                Longitude = longitude
            };
            if (chat_id != default)
                args.Chat_id = chat_id;
            if (message_id != default)
                args.Message_id = message_id;
            if (inline_message_id != default)
                args.Inline_message_id = inline_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            var json_result = await T.RPCA<JsonElement>("editMessageLiveLocation", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="jsonstream">Json Stream parameters.</param>
        public static dynamic EditMessageLiveLocation(this BotClient T, Stream jsonstream)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (jsonstream == default)
                throw new System.ArgumentNullException(nameof(jsonstream));
            var json_result = T.RPC<JsonElement>("editMessageLiveLocation", jsonstream);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="jsonstream">Json Stream parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<dynamic> EditMessageLiveLocationAsync(this BotClient T, Stream jsonstream, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (jsonstream == default)
                throw new System.ArgumentNullException(nameof(jsonstream));
            var json_result = await T.RPCA<JsonElement>("editMessageLiveLocation", jsonstream, cancellationToken).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
    }
}