// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, SendAnimationArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return args.UseMultipart() ? bot.RPCF<Message>("sendAnimation", args) : bot.RPC<Message>("sendAnimation", args);
        }
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, string chat_id, string animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] string thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] IEnumerable<AttachFile> attachFiles)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, long chat_id, string animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] string thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] IEnumerable<AttachFile> attachFiles)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, string chat_id, InputFile animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, long chat_id, InputFile animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, SendAnimationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await (args.UseMultipart() ? bot.RPCAF<Message>("sendAnimation", args, cancellationToken: cancellationToken).ConfigureAwait(false) : bot.RPCA<Message>("sendAnimation", args, cancellationToken: cancellationToken).ConfigureAwait(false));
        }
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, string chat_id, string animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] string thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] IEnumerable<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
                AttachFiles = attachFiles
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, long chat_id, string animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] string thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] IEnumerable<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
                AttachFiles = attachFiles
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, string chat_id, InputFile animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parse_mode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, long chat_id, InputFile animation, [Optional] uint duration, [Optional] uint width, [Optional] uint height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parse_mode, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                Chat_id = chat_id,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                Parse_mode = parse_mode,
                Disable_notification = disable_notification,
                Reply_to_message_id = reply_to_message_id,
                Reply_markup = reply_markup,
            }, cancellationToken).ConfigureAwait(false);
        }
    }
}
