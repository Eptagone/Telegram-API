﻿using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="sticker_set_name">Name of the sticker set to be set as the group sticker set.</param>
        public static bool SetChatStickerSet(this BotClient T, object chat_id, string sticker_set_name) => T.RPC<bool>("setChatStickerSet", new JObject { new JProperty("chat_id", chat_id), new JProperty("sticker_set_name", sticker_set_name) });
    }
}