// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Payments
{
    /// <summary>Payments</summary>
    public static partial class PaymentsMethods
    {
        /// <summary>Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="pre_checkout_query_id">Unique identifier for the query to be answered.</param>
        /// <param name="ok">Specify True if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use False if there are any problems.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
        /// <returns>On success, True is returned.</returns>
        public static bool AnswerPreCheckoutQuery(this BotClient T, string pre_checkout_query_id, bool ok, [Optional] string error_message)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("pre_checkout_query_id", pre_checkout_query_id);
            json.WriteBoolean("ok", ok);
            if (!ok)
            {
                if (error_message == default)
                    throw new System.ArgumentNullException(nameof(error_message));
                json.WriteString("error_message", error_message);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("answerPreCheckoutQuery", stream);
        }
        /// <summary>Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="pre_checkout_query_id">Unique identifier for the query to be answered.</param>
        /// <param name="ok">Specify True if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use False if there are any problems.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
        /// <returns>On success, True is returned.</returns>
        public static async Task<bool> AnswerPreCheckoutQueryAsync(this BotClient T, string pre_checkout_query_id, bool ok, string error_message = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("pre_checkout_query_id", pre_checkout_query_id);
            json.WriteBoolean("ok", ok);
            if (!ok)
            {
                if (error_message == default)
                    throw new System.ArgumentNullException(nameof(error_message));
                json.WriteString("error_message", error_message);
            }
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("answerPreCheckoutQuery", stream).ConfigureAwait(false);
        }
    }
}
