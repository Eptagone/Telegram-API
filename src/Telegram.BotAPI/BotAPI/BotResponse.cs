// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI
{
    /// <summary>Represents the bot's response to the request.</summary>
    /// <typeparam name="T">Result type.</typeparam>
    public sealed class BotResponse<T>
    {
        /// <summary>True, if the request was successful, otherwise false.</summary>
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
        /// <summary>Result.</summary>
        [JsonPropertyName("result")]
        public T Result { get; set; }
        ///<summary>Error code.</summary>
        [JsonPropertyName("error_code")]
        public int ErrorCode { get; set; }
        ///<summary>Error description.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
