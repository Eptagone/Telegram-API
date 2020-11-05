// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents an animated emoji that displays a random value.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Dice
    {
        /// <summary>Emoji on which the dice throw animation is based.</summary>
        [JsonPropertyName("emoji")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; set; }
        /// <summary>Value of the dice, 1-6 for “🎲” and “🎯” base emoji, 1-5 for “🏀” and “⚽” base emoji, 1-64 for “🎰” base emoji.</summary>
        [JsonPropertyName("Value")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Value { get; set; }
    }

    /// <summary>Dice base emojis. Choose between different animations (dice, darts, basketball, football, slot machine) by specifying the emoji parameter in the method sendDice.</summary>
    public sealed class DiceValue
    {
        /// <summary>Dice: 🎲 1 - 6 </summary>
        public const string Dice = "🎲";
        /// <summary>Darts: 🎯 </summary>
        public const string Darts = "🎯";
        /// <summary>Basketball: 🏀 </summary>
        public const string Basketball = "🏀";
        /// <summary>Football: 🏀 </summary>
        public const string Football = "⚽";
        /// <summary>Slot machine: 🏀 </summary>
        public const string SlotMachine = "🎰";
    }
}
