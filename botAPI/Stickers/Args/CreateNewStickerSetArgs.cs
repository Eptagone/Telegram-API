﻿using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    /// <summary>CreateNewStickerSet method arguments.</summary>
    public class CreateNewStickerSetArgs
    {
        /// <summary>User identifier of created sticker set owner.</summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public int User_id { get; set; }
        /// <summary>Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }
        /// <summary>Sticker set title, 1-64 characters.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "png_sticker", Required = Required.Always)]
        public string Png_sticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonProperty(PropertyName = "emojis", Required = Required.Always)]
        public string Emojis { get; set; }
        /// <summary>Optional. Pass True, if a set of mask stickers should be created.</summary>
        [JsonProperty(PropertyName = "contains_masks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Contains_masks { get; set; }
        /// <summary>Optional. A JSON object for position where the mask should be placed on faces.</summary>
        [JsonProperty(PropertyName = "mask_position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition Mask_position { get; set; }
    }
}