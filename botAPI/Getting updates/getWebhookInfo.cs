namespace TelegramAPI.Getting_updates
{
    public static partial class Getting_updates
    {
        /// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
        public static WebhookInfo GetWebhookInfo(this BotClient T) => T.RPC<WebhookInfo>("getWebhookInfo");
    }
}