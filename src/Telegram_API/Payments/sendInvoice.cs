// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Payments
{
    public static partial class Payments
    {
        /// <summary>Use this method to send invoices. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters</param>
        public static Available_Types.Message SendInvoice(this BotClient T, SendInvoiceArgs args) => T.RPC<Available_Types.Message>("sendInvoice", args);
    }
}
