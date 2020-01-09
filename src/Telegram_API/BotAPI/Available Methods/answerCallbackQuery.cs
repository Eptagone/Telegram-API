// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool AnswerCallbackQuery(this BotClient T, AnswerCallbackQueryArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("answerCallbackQuery", args);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<bool> AnswerCallbackQueryAsync(this BotClient T, AnswerCallbackQueryArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("answerCallbackQuery", args).ConfigureAwait(true);
        }
    }
}