// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object contains information about a poll.</summary>
    public sealed class Poll
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Poll question, 1-255 characters.</summary>
        [JsonProperty(PropertyName = "question", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Question { get; set; }
        /// <summary>List of poll options.</summary>
        [JsonProperty(PropertyName = "options", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PollOption[] Options { get; set; }
        /// <summary>True, if the poll is closed.</summary>
        [JsonProperty(PropertyName = "is_closed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_closed { get; set; }
    }
}
