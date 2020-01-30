// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;
namespace Telegram.BotAPI.Stickers
{
    /// <summary>CreateNewStickerSet method arguments.</summary>
    public sealed class CreateNewStickerSetArgs
    {
        /// <summary>User identifier of created sticker set owner.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>Sticker set title, 1-64 characters.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName("png_sticker")]
        public string Png_sticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonPropertyName("emojis")]
        public string Emojis { get; set; }
        /// <summary>Optional. Pass True, if a set of mask stickers should be created.</summary>
        [JsonPropertyName("contains_masks")]
        public bool Contains_masks { get; set; }
        /// <summary>Optional. A JSON object for position where the mask should be placed on faces.</summary>
        [JsonPropertyName("mask_position")]
        public MaskPosition Mask_position { get; set; }
        internal bool UseMultipart()
        {
            if (Png_sticker != default)
                if (Png_sticker.GetType() == typeof(InputFile))
                    return true;
            return false;
        }
    }
}