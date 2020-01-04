// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Getting_updates
{
    /// <summary>Available update types.</summary>
    public enum UpdateType
    {
        /// <summary>Unknown update type</summary>
        Unknown,
        /// <summary>Message update</summary>
        Message,
        /// <summary>Edited message update</summary>
        Edited_message,
        /// <summary>Channel post update</summary>
        Channel_post,
        /// <summary>Edited channel post update</summary>
        Edited_channel_post,
        /// <summary>Inline query update</summary>
        Inline_query,
        /// <summary>Chosen inline result update</summary>
        Chosen_inline_result,
        /// <summary>Callback query update</summary>
        Callback_query,
        /// <summary>Shipping query update</summary>
        Shipping_query,
        /// <summary>Pre checkout query update</summary>
        Pre_checkout_query,
        /// <summary>Poll update</summary>
        Poll
    }
}
