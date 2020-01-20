// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Buffers;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Telegram_Passport;

namespace Telegram.BotAPI
{
    internal static class JsonTools
    {
        internal static T ToObject<T>(this JsonElement element, JsonSerializerOptions options = default)
        {
            var buffer = new ArrayBufferWriter<byte>();
            using var writer = new Utf8JsonWriter(buffer);
            element.WriteTo(writer);
            return JsonSerializer.Deserialize<T>(buffer.WrittenSpan, options);
        }
        internal static bool IsNumber(this object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }
        public class CallbackGameJsonConverter : JsonConverter<CallbackGame>
        {
            public override CallbackGame Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return reader.GetString();
            }
            public override void Write(Utf8JsonWriter writer, CallbackGame value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value);
            }
        }
        public class UintJsonConverter : JsonConverter<uint>
        {
            public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return reader.GetUInt32();
            }
            public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
            {
                if (value == default)
                    writer.WriteNullValue();
                else
                    writer.WriteNumberValue(value);
            }
        }
        public class UshortJsonConverter : JsonConverter<ushort>
        {
            public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return reader.GetUInt16();
            }
            public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
            {
                if (value == default)
                    writer.WriteNullValue();
                else
                    writer.WriteNumberValue(value);
            }
        }
        public class InputMediaJsonConverter : JsonConverter<InputMedia>
        {
            public override InputMedia Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override void Write(Utf8JsonWriter writer, InputMedia value, JsonSerializerOptions options)
            {
                if(value is InputMediaAnimation inputMediaAnimation)
                {
                    JsonSerializer.Serialize(writer, inputMediaAnimation, typeof(InputMediaAnimation), options);
                    return;
                }
                if(value is InputMediaAudio inputMediaAudio)
                {
                    JsonSerializer.Serialize(writer, inputMediaAudio, typeof(InputMediaAudio), options);
                    return;
                }
                if(value is InputMediaDocument inputMediaDocument)
                {
                    JsonSerializer.Serialize(writer, inputMediaDocument, typeof(InputMediaDocument), options);
                    return;
                }
                if(value is InputMediaPhoto inputMediaPhoto)
                {
                    JsonSerializer.Serialize(writer, inputMediaPhoto, typeof(InputMediaPhoto), options);
                    return;
                }
                if(value is InputMediaVideo inputMediaVideo)
                {
                    JsonSerializer.Serialize(writer, inputMediaVideo, typeof(InputMediaVideo), options);
                }
            }
        }
        public class PassportElementErrorJsonConverter : JsonConverter<PassportElementError>
        {
            public override PassportElementError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, PassportElementError value, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
        public class ReplyMarkupConverter : JsonConverter<ReplyMarkup>
        {
            public override ReplyMarkup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var replymarkup = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
                if(replymarkup.TryGetProperty("force_reply", out JsonElement force_reply))
                {
                    return JsonSerializer.Deserialize<ForceReply>(ref reader, options);
                }
                if(replymarkup.TryGetProperty("keyboard", out JsonElement replykeyboard))
                {
                    return JsonSerializer.Deserialize<ReplyKeyboardMarkup>(ref reader, options);
                }
                if(replymarkup.TryGetProperty("inline_keyboard", out JsonElement inline_keyboard))
                {
                    return JsonSerializer.Deserialize<InlineKeyboardMarkup>(ref reader, options);
                }
                if(replymarkup.TryGetProperty("remove_keyboard", out JsonElement remove_keyboard))
                {
                    return JsonSerializer.Deserialize<ReplyKeyboardRemove>(ref reader, options);
                }
                return default;
            }
            public override void Write(Utf8JsonWriter writer, ReplyMarkup value, JsonSerializerOptions options)
            {
                if(value is ForceReply forceReply)
                {
                    writer.WriteStartObject();
                    writer.WriteBoolean("force_reply", true);
                    if (forceReply.Selective)
                        writer.WriteBoolean("selective", true);
                    writer.WriteEndObject();
                }
                if(value is ReplyKeyboardMarkup replyKeyboardMarkup)
                {
                    writer.WriteStartObject();
                    writer.WriteStartArray("keyboard");
                    foreach(var ka in replyKeyboardMarkup.Keyboard)
                    {
                        writer.WriteStartArray();
                        foreach(var button in ka)
                        {
                            writer.WriteStartObject();
                            writer.WriteString("text", button.Text);
                            if (button.Request_contact)
                                writer.WriteBoolean("request_contact", true);
                            if (button.Request_location)
                                writer.WriteBoolean("request_location", true);
                            writer.WriteEndObject();
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndArray();
                    if (replyKeyboardMarkup.Resize_keyboard)
                        writer.WriteBoolean("resize_keryboard", true);
                    if (replyKeyboardMarkup.One_time_keyboard)
                        writer.WriteBoolean("one_time_keyboard", true);
                    if (replyKeyboardMarkup.Selective)
                        writer.WriteBoolean("selective", true);
                    writer.WriteEndObject();
                }
                if(value is InlineKeyboardMarkup inlineKeyboardMarkup)
                {
                    writer.WriteStartObject();
                    writer.WriteStartArray("inline_keyboard");
                    foreach(var ink in inlineKeyboardMarkup.Inline_keyboard)
                    {
                        writer.WriteStartArray();
                        foreach(var button in ink)
                        {
                            writer.WriteStartObject();
                            writer.WriteString("text", button.Text);
                            switch (button.ButtonType)
                            {
                                case InlineKeyboardButtonType.Url:
                                    writer.WriteString("url", button.Url);
                                    break;
                                case InlineKeyboardButtonType.Login_Url:
                                    writer.WriteStartObject("login_url");
                                    writer.WriteString("url", button.Login_url.Url);
                                    if (button.Login_url.Forward_text != default)
                                        writer.WriteString("forward_text", button.Login_url.Forward_text);
                                    if (button.Login_url.Bot_username != default)
                                        writer.WriteString("bot_username", button.Login_url.Bot_username);
                                    if (button.Login_url.Request_write_access)
                                        writer.WriteBoolean("request_write_access", true);
                                    writer.WriteEndObject();
                                    break;
                                case InlineKeyboardButtonType.Callback_data:
                                    writer.WriteString("callback_data", button.Callback_data);
                                    break;
                                case InlineKeyboardButtonType.Switch_inline_query:
                                    writer.WriteString("switch_inline_query", button.Switch_inline_query);
                                    break;
                                case InlineKeyboardButtonType.Switch_inline_query_current_chat:
                                    writer.WriteString("switch_inline_query_current_chat", button.Switch_inline_query_current_chat);
                                    break;
                                case InlineKeyboardButtonType.Callback_game:
                                    writer.WriteString("callback_game", button.Callback_game);
                                    break;
                                case InlineKeyboardButtonType.Pay:
                                    writer.WriteBoolean("pay", button.Pay);
                                    break;
                            }
                            writer.WriteEndObject();
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndArray();
                    writer.WriteEndObject();
                }
                if(value is ReplyKeyboardRemove replyKeyboardRemove)
                {
                    writer.WriteStartObject();
                    writer.WriteBoolean("remove_keyboard", true);
                    if (replyKeyboardRemove.Selective)
                        writer.WriteBoolean("selective", true);
                    writer.WriteEndObject();
                }
            }
        }
    }
}
