// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Inline_mode
{
    /// <summary>Inline mode</summary>
    public static class Inline_mode
    {
        /// <summary>Use this method to send answers to an inline query. On success, True is returned. 
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool AnswerInlineQuery(this BotClient T, AnswerInlineQueryArgs args) => T.RPC<bool>("answerInlineQuery", args);
    }
}