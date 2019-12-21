namespace TelegramAPI.Getting_updates
{
    /// <summary>Available update types.</summary>
    public enum UpdateType : ushort
    {
        Undefined,
        Message, 
        Edited_message,
        Channel_post,
        Edited_channel_post,
        Inline_query,
        Chosen_inline_result,
        Callback_query,
        Shipping_query,
        Pre_checkout_query,
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
            return UpdateType.Undefined;
        }
    }
}
