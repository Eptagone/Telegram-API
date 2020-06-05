// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents one button of an inline keyboard. You must use exactly one of the optional fields.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineKeyboardButton
    {
        ///<summary>Label text on the button.</summary>
        [JsonPropertyName("text")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. HTTP or tg:// url to be opened when button is pressed.</summary>
        [JsonPropertyName("url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        ///<summary>Optional. An HTTP URL used to automatically authorize the user. Can be used as a replacement for the Telegram Login Widget.</summary>
        [JsonPropertyName("login_url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LoginUrl Login_url { get; set; }
        ///<summary>Optional. Data to be sent in a callback query to the bot when button is pressed, 1-64 bytes.</summary>
        [JsonPropertyName("callback_data")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Callback_data { get; set; }
        ///<summary>Optional. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot‘s username and the specified inline query in the input field. Can be empty, in which case just the bot’s username will be inserted.<para>Note: This offers an easy way for users to start using your bot in inline mode when they are currently in a private chat with it. Especially useful when combined with switch_pm… actions – in this case the user will be automatically returned to the chat they switched from, skipping the chat selection screen.</para></summary>
        [JsonPropertyName("switch_inline_query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Switch_inline_query { get; set; }
        ///<summary>Optional. If set, pressing the button will insert the bot‘s username and the specified inline query in the current chat's input field. Can be empty, in which case only the bot’s username will be inserted.</summary>
        [JsonPropertyName("switch_inline_query_current_chat")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Switch_inline_query_current_chat { get; set; }
        ///<summary>Optional. Description of the game that will be launched when the user presses the button.<para>NOTE: This type of button must always be the first button in the first row.</para></summary>
        [JsonPropertyName("callback_game")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallbackGame Callback_game { get; set; }
        ///<summary>Optional. Specify True, to send a Pay button.<para>NOTE: This type of button must always be the first button in the first row.</para></summary>
        [JsonPropertyName("pay")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Pay { get; set; }
        ///<summary>Button Type.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public InlineKeyboardButtonType Type
        {
            get
            {
                if (Url != default)
                    return InlineKeyboardButtonType.Url;
                if (Login_url != default)
                    return InlineKeyboardButtonType.Login_Url;
                if (Callback_data != default)
                    return InlineKeyboardButtonType.Callback_data;
                if (Switch_inline_query != default)
                    return InlineKeyboardButtonType.Switch_inline_query;
                if (Switch_inline_query_current_chat != default)
                    return InlineKeyboardButtonType.Switch_inline_query_current_chat;
                if (Callback_game != default)
                    return InlineKeyboardButtonType.Callback_game;
                if (Pay != default)
                    return InlineKeyboardButtonType.Pay;
                return InlineKeyboardButtonType.Unknown;
            }
        }
        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a url.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="url">Url.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetUrl(string text, string url)
        {
            return new InlineKeyboardButton { Text = text, Url = url };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a <see cref="LoginUrl"/>.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="login_url">A <see cref="LoginUrl"/></param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetLoginUrl(string text, LoginUrl login_url)
        {
            return new InlineKeyboardButton { Text = text, Login_url = login_url };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a Callback data.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="callback_data">Callback data.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetCallbackData(string text, string callback_data)
        {
            return new InlineKeyboardButton { Text = text, Callback_data = callback_data };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a inline query.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="switch_inline_query">Inline query.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetSwitchInlineQuery(string text, string switch_inline_query)
        {
            return new InlineKeyboardButton { Text = text, Switch_inline_query = switch_inline_query };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a inline query for the current chat.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="switch_inline_query_current_chat">Inline query.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetSwitchInlineQueryCurrentChat(string text, string switch_inline_query_current_chat)
        {
            return new InlineKeyboardButton { Text = text, Switch_inline_query_current_chat = switch_inline_query_current_chat };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> with a callback game.</summary>
        /// <param name="text">Button text.</param>
        /// <param name="callback_game">Callback game.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetCallbackGame(string text, CallbackGame callback_game)
        {
            return new InlineKeyboardButton { Text = text, Callback_game = callback_game };
        }

        /// <summary>Create a new <see cref="InlineKeyboardButton"/> for pay.</summary>
        /// <param name="text">Button text.</param>
        /// <returns><see cref="InlineKeyboardButton"/></returns>
        public static InlineKeyboardButton SetPay(string text)
        {
            return new InlineKeyboardButton { Text = text, Pay = true };
        }
    }
    /// <summary>inlinekeyboardbutton Type</summary>
    public enum InlineKeyboardButtonType
    {
        /// <summary>Unknown button.</summary>
        Unknown,
        /// <summary>Url button.</summary>
        Url,
        /// <summary>Login Url button.</summary>
        Login_Url,
        /// <summary>Callback_data button.</summary>
        Callback_data,
        /// <summary>Switch_inline_query button.</summary>
        Switch_inline_query,
        /// <summary>Switch_inline_query_current_chat button.</summary>
        Switch_inline_query_current_chat,
        /// <summary>Callback_game button.</summary>
        Callback_game,
        /// <summary>Pay button.</summary>
        Pay
    }
}