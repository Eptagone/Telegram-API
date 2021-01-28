// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a bot command.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommand
    {
        /// <summary>New Bot Command</summary>
        public BotCommand() { }
        /// <summary>New Bot Command</summary>
        /// <param name="command">Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</param>
        /// <param name="description">Description of the command, 3-256 characters.</param>
        public BotCommand(string command, string description)
        {
            Command = command;
            Description = description;
        }

        /// <summary>Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</summary>
        [JsonPropertyName(PropertyNames.Command)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Command { get; set; }
        /// <summary>Description of the command, 3-256 characters.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
