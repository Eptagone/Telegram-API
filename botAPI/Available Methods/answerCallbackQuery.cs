namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool AnswerCallbackQuery(this BotClient T, AnswerCallbackQueryArgs args) => T.RPC<bool>("answerCallbackQuery", args);
    }
}