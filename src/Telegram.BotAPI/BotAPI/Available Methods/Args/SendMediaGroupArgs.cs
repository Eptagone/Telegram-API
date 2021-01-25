// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendMediaGroud method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendMediaGroupArgs : BaseSendArgs, IAttachFiles
    {
        ///<summary>A JSON array of <see cref="InputMedia"/> and <see cref="InputMedia"/>, describing photos and videos to be sent, must include 2–10 items.</summary>
        [JsonPropertyName("media")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InputMedia> Media { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public IEnumerable<AttachFile> AttachFiles { get; set; }
        internal bool UseMultipart()
        {
            return AttachFiles != default;
        }
    }
}