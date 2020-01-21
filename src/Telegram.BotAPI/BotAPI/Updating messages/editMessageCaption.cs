﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
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
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var json_result = T.RPC<JsonElement>("editMessageCaption", args, options);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit captions of messages. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<dynamic> EditMessageCaptionAsync(this BotClient T, EditMessageCaptionArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var json_result = await T.RPCA<JsonElement>("editMessageCaption", args, options).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
    }
}