using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
namespace TelegramAPI.Payments
{
    /// <summary>Payments</summary>
    public static partial class Payments
    {
        /// <summary>Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="pre_checkout_query_id">Unique identifier for the query to be answered.</param>
        /// <param name="ok">Specify True if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use False if there are any problems.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
        /// <returns>On success, True is returned.</returns>
        public static bool AnswerPreCheckoutQuery(this BotClient T, string pre_checkout_query_id, bool ok, [Optional] string error_message)
        {
            var output = new JObject
            {
                new JProperty("pre_checkout_query_id", pre_checkout_query_id),
                new JProperty("ok", ok)
            };
            if (!ok)
                output["error_message"] = error_message;
            return T.RPC<bool>("answerPreCheckoutQuery", output);
        }
    }
}
