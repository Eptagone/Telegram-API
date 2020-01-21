// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Buffers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Telegram_Passport;
using Telegram.BotAPI.Inline_mode;

namespace Telegram.BotAPI
{
    internal static class JsonTools
    {
        internal static T ToObject<T>(this JsonElement element, JsonSerializerOptions options = default)
        {
            var buffer = new ArrayBufferWriter<byte>();
            using var writer = new Utf8JsonWriter(buffer);
            element.WriteTo(writer); writer.Flush();
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
                    return;
                }
                writer.WriteNullValue();
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
                if(value is PassportElementErrorDataField dataField)
                {
                    JsonSerializer.Serialize(writer, dataField, typeof(PassportElementErrorDataField), options);
                    return;
                }
                if(value is PassportElementErrorFrontSide frontSide)
                {
                    JsonSerializer.Serialize(writer, frontSide, typeof(PassportElementErrorFrontSide), options);
                    return;
                }
                if(value is PassportElementErrorReverseSide reverseSide)
                {
                    JsonSerializer.Serialize(writer, reverseSide, typeof(PassportElementErrorReverseSide), options);
                    return;
                }
                if(value is PassportElementErrorSelfie errorSelfie)
                {
                    JsonSerializer.Serialize(writer, errorSelfie, typeof(PassportElementErrorSelfie), options);
                    return;
                }
                if(value is PassportElementErrorFile errorFile)
                {
                    JsonSerializer.Serialize(writer, errorFile, typeof(PassportElementErrorFile), options);
                    return;
                }
                if(value is PassportElementErrorFiles errorFiles)
                {
                    JsonSerializer.Serialize(writer, errorFiles, typeof(PassportElementErrorFiles), options);
                    return;
                }
                if(value is PassportElementErrorTranslationFile translationFile)
                {
                    JsonSerializer.Serialize(writer, translationFile, typeof(PassportElementErrorTranslationFile), options);
                    return;
                }
                if(value is PassportElementErrorTranslationFiles translationFiles)
                {
                    JsonSerializer.Serialize(writer, translationFiles, typeof(PassportElementErrorTranslationFiles), options);
                    return;
                }
                if(value is PassportElementErrorUnspecified unspecified)
                {
                    JsonSerializer.Serialize(writer, unspecified, typeof(PassportElementErrorUnspecified), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InlineQueryResultConverter : JsonConverter<InlineQueryResult>
        {
            public override InlineQueryResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, InlineQueryResult value, JsonSerializerOptions options)
            {
                if(value is InlineQueryResultCachedAudio cachedAudio)
                {
                    JsonSerializer.Serialize(writer, cachedAudio, typeof(InlineQueryResultCachedAudio), options);
                    return;
                }
                if(value is InlineQueryResultCachedDocument cachedDocument)
                {
                    JsonSerializer.Serialize(writer, cachedDocument, typeof(InlineQueryResultCachedDocument), options);
                    return;
                }
                if(value is InlineQueryResultCachedGif cachedGif)
                {
                    JsonSerializer.Serialize(writer, cachedGif, typeof(InlineQueryResultCachedGif), options);
                    return;
                }
                if(value is InlineQueryResultCachedMpeg4Gif cachedMpeg4Gif)
                {
                    JsonSerializer.Serialize(writer, cachedMpeg4Gif, typeof(InlineQueryResultCachedMpeg4Gif), options);
                    return;
                }
                if(value is InlineQueryResultCachedPhoto cachedPhoto)
                {
                    JsonSerializer.Serialize(writer, cachedPhoto, typeof(InlineQueryResultCachedPhoto), options);
                    return;
                }
                if(value is InlineQueryResultCachedSticker cachedSticker)
                {
                    JsonSerializer.Serialize(writer, cachedSticker, typeof(InlineQueryResultCachedSticker), options);
                    return;
                }
                if(value is InlineQueryResultCachedVideo cachedVideo)
                {
                    JsonSerializer.Serialize(writer, cachedVideo, typeof(InlineQueryResultCachedVideo), options);
                    return;
                }
                if(value is InlineQueryResultCachedVoice cachedVoice)
                {
                    JsonSerializer.Serialize(writer, cachedVoice, typeof(InlineQueryResultCachedVoice), options);
                    return;
                }
                if(value is InlineQueryResultArticle article)
                {
                    JsonSerializer.Serialize(writer, article, typeof(InlineQueryResultArticle), options);
                    return;
                }
                if(value is InlineQueryResultAudio audio)
                {
                    JsonSerializer.Serialize(writer, audio, typeof(InlineQueryResultAudio), options);
                    return;
                }
                if(value is InlineQueryResultContact contact)
                {
                    JsonSerializer.Serialize(writer, contact, typeof(InlineQueryResultContact), options);
                    return;
                }
                if(value is InlineQueryResultGame game)
                {
                    JsonSerializer.Serialize(writer, game, typeof(InlineQueryResultGame), options);
                    return;
                }
                if(value is InlineQueryResultDocument document)
                {
                    JsonSerializer.Serialize(writer, document, typeof(InlineQueryResultDocument), options);
                    return;
                }
                if(value is InlineQueryResultGif gif)
                {
                    JsonSerializer.Serialize(writer, gif, typeof(InlineQueryResultGif), options);
                    return;
                }
                if(value is InlineQueryResultLocation location)
                {
                    JsonSerializer.Serialize(writer, location, typeof(InlineQueryResultLocation), options);
                    return;
                }
                if(value is InlineQueryResultMpeg4Gif mpeg4Gif)
                {
                    JsonSerializer.Serialize(writer, mpeg4Gif, typeof(InlineQueryResultMpeg4Gif), options);
                    return;
                }
                if(value is InlineQueryResultPhoto photo)
                {
                    JsonSerializer.Serialize(writer, photo, typeof(InlineQueryResultPhoto), options);
                    return;
                }
                if(value is InlineQueryResultVenue venue)
                {
                    JsonSerializer.Serialize(writer, venue, typeof(InlineQueryResultVenue), options);
                    return;
                }
                if(value is InlineQueryResultVideo video)
                {
                    JsonSerializer.Serialize(writer, video, typeof(InlineQueryResultVideo), options);
                    return;
                }
                if(value is InlineQueryResultVoice voice)
                {
                    JsonSerializer.Serialize(writer, voice, typeof(InlineQueryResultVoice), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InputMessageContentConverter : JsonConverter<InputMessageContent>
        {
            public override InputMessageContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, InputMessageContent value, JsonSerializerOptions options)
            {
                if(value is InputTextMessageContent inputText)
                {
                    JsonSerializer.Serialize(writer, inputText, typeof(InputTextMessageContent), options);
                    return;
                }
                if(value is InputLocationMessageContent inputLocation)
                {
                    JsonSerializer.Serialize(writer, inputLocation, typeof(InputLocationMessageContent), options);
                    return;
                }
                if(value is InputVenueMessageContent inputVenue)
                {
                    JsonSerializer.Serialize(writer, inputVenue, typeof(InputVenueMessageContent), options);
                    return;
                }
                if(value is InputContactMessageContent inputContact)
                {
                    JsonSerializer.Serialize(writer, inputContact, typeof(InputContactMessageContent), options);
                    return;
                }
                writer.WriteNullValue();
            }
        }
        public class InlineKeyboardMarkupConverter : JsonConverter<InlineKeyboardMarkup>
        {
            public override InlineKeyboardMarkup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return JsonSerializer.Deserialize<InlineKeyboardMarkup>(ref reader, options);
            }

            public override void Write(Utf8JsonWriter writer, InlineKeyboardMarkup value, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                writer.WriteStartArray("inline_keyboard");
                foreach (var ink in value.Inline_keyboard)
                {
                    writer.WriteStartArray();
                    foreach (var button in ink)
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
                                writer.WriteStartObject("callback_game");
                                writer.WriteString("game_short_name", button.Callback_game.Game_short_name);
                                writer.WriteEndObject();
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
                return;
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
                    return;
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
                    return;
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
                                    writer.WriteStartObject("callback_game");
                                    writer.WriteString("game_short_name", button.Callback_game.Game_short_name);
                                    writer.WriteEndObject();
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
                    return;
                }
                if(value is ReplyKeyboardRemove replyKeyboardRemove)
                {
                    writer.WriteStartObject();
                    writer.WriteBoolean("remove_keyboard", true);
                    if (replyKeyboardRemove.Selective)
                        writer.WriteBoolean("selective", true);
                    writer.WriteEndObject();
                    return;
                }
                writer.WriteNullValue();
            }
        }
    }
}
