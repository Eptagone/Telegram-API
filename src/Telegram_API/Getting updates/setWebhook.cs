// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Getting_updates
{
    public static partial class Getting_updates
    {
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool SetWebhook(this BotClient T, SetWebhookArgs args) => T.RPC<bool>("setWebhook", args);
    }
}