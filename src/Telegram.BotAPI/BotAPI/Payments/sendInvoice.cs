// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Payments
{
    public static partial class PaymentsMethods
    {
        /// <summary>Use this method to send invoices. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters</param>
        public static Message SendInvoice(this BotClient T, SendInvoiceArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPC<Message>("sendInvoice", args);
        }
        /// <summary>Use this method to send invoices. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters</param>
        public static async Task<Message> SendInvoiceAsync(this BotClient T, SendInvoiceArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCA<Message>("sendInvoice", args).ConfigureAwait(false);
        }
    }
}
