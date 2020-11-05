// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    /// <summary>Interface for <see cref="InputMedia"/> objects</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public interface IInputMedia : IParseMode, ICaption
    {
        ///<summary>Type of the result.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; }
        ///<summary>File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</summary>
        [JsonPropertyName("media")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
    }
}
