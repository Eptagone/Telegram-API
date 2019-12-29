// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
namespace TelegramAPI.Payments
{
    public static partial class Payments
    {
        /// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="shipping_query_id">Unique identifier for the query to be answered</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <param name="shipping_options">Required if ok is True. A JSON-serialized array of available shipping options.</param>
        /// <param name="error_message">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <returns></returns>
        public static Available_Types.Message AnswerShippingQuery(this BotClient T, string shipping_query_id, bool ok, [Optional] ShippingOption[] shipping_options, [Optional] string error_message) => T.RPC<Available_Types.Message>("answerShippingQuery", new JObject { new JProperty("shipping_query_id", shipping_query_id), new JProperty("ok", ok), ok ? new JProperty("shipping_options", shipping_options) : new JProperty("error_message", error_message) });
    }
}
