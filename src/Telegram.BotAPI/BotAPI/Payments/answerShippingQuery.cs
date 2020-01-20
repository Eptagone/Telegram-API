// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Payments
{
    public static partial class PaymentsMethods
    {
        /// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="shipping_query_id">Unique identifier for the query to be answered</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <param name="shipping_options">Required if ok is True. A JSON-serialized array of available shipping options.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <returns></returns>
        public static Message AnswerShippingQuery(this BotClient T, string shipping_query_id, bool ok, [Optional] ShippingOption[] shipping_options, [Optional] string error_message)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("shipping_query_id", shipping_query_id);
            json.WriteBoolean("ok", ok);
            if (ok)
            {
                if (shipping_options == default)
                    throw new System.ArgumentNullException(nameof(shipping_options));
                json.WriteStartArray("shipping_options");
                foreach (var option in shipping_options)
                {
                    json.WriteStartObject();
                    json.WriteString("id", option.Id);
                    json.WriteString("title", option.Title);
                    json.WriteStartArray("prices");
                    foreach (var price in option.Prices)
                    {
                        json.WriteStartObject();
                        json.WriteString("label", price.Label);
                        json.WriteNumber("amount", price.Amount);
                        json.WriteEndObject();
                    }
                    json.WriteEndArray();
                    json.WriteEndObject();
                }
                json.WriteEndArray();
            }
            else
            {
                if (error_message == default)
                    throw new System.ArgumentNullException(nameof(error_message));
                json.WriteString("error_message", error_message);

            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("answerShippingQuery", stream);
        }
        /// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="shipping_query_id">Unique identifier for the query to be answered</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <param name="shipping_options">Required if ok is True. A JSON-serialized array of available shipping options.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <returns></returns>
        public static async Task<Message> AnswerShippingQueryAsync(this BotClient T, string shipping_query_id, bool ok, [Optional] ShippingOption[] shipping_options, [Optional] string error_message)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("shipping_query_id", shipping_query_id);
            json.WriteBoolean("ok", ok);
            if (ok)
            {
                if (shipping_options == default)
                    throw new System.ArgumentNullException(nameof(shipping_options));
                json.WriteStartArray("shipping_options");
                foreach (var option in shipping_options)
                {
                    json.WriteStartObject();
                    json.WriteString("id", option.Id);
                    json.WriteString("title", option.Title);
                    json.WriteStartArray("prices");
                    foreach (var price in option.Prices)
                    {
                        json.WriteStartObject();
                        json.WriteString("label", price.Label);
                        json.WriteNumber("amount", price.Amount);
                        json.WriteEndObject();
                    }
                    json.WriteEndArray();
                    json.WriteEndObject();
                }
                json.WriteEndArray();
            }
            else
            {
                if (error_message == default)
                    throw new System.ArgumentNullException(nameof(error_message));
                json.WriteString("error_message", error_message);

            }
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("answerShippingQuery", stream).ConfigureAwait(false);
        }
    }
}
