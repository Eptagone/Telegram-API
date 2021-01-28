﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, SendPhotoArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<Message>("sendPhoto", args);
        }
        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, long chat_id, string photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendPhoto(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            });
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, string chat_id, string photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendPhoto(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            });
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, long chat_id, InputFile photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendPhoto(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            });
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, string chat_id, InputFile photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendPhoto(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            });
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, SendPhotoArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<Message>("sendPhoto", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, long chat_id, string photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendPhotoAsync(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, string chat_id, string photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendPhotoAsync(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, long chat_id, InputFile photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendPhotoAsync(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</param>
        /// <param name="caption">Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, string chat_id, InputFile photo, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendPhotoAsync(new SendPhotoArgs
            {
                ChatId = chat_id,
                Photo = photo,
                Caption = caption,
                ParseMode = parse_mode,
                DisableNotification = disable_notification,
                ReplyToMessageId = reply_to_message_id,
                ReplyMarkup = reply_markup
            }, cancellationToken).ConfigureAwait(false);
        }
    }
}