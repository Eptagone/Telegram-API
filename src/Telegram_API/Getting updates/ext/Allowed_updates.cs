// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
namespace TelegramAPI.Getting_updates
{
    /// <summary>Available update types.</summary>
    public enum UpdateType : ushort
    {
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
    public static partial class Getting_updates
    {
        /// <summary>Get update type.</summary>
        /// <param name="U">Update</param>
        public static UpdateType GetUpdateType(this Update U)
        {
            if (U.Message != null)
                return UpdateType.Message;
            if (U.Edited_message != null)
                return UpdateType.Edited_message;
            if (U.Channel_post != null)
                return UpdateType.Channel_post;
            if (U.Edited_channel_post != null)
                return UpdateType.Edited_channel_post;
            if (U.Inline_query != null)
                return UpdateType.Inline_query;
            if (U.Chosen_inline_result != null)
                return UpdateType.Chosen_inline_result;
            if (U.Callback_query != null)
                return UpdateType.Callback_query;
            if (U.Shipping_query != null)
                return UpdateType.Shipping_query;
            if (U.Pre_checkout_query != null)
                return UpdateType.Pre_checkout_query;
            if (U.Poll != null)
                return UpdateType.Poll;
            throw new MissingMemberException("The Update object is invalid");
        }
    }
}
