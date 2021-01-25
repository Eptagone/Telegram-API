// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, string chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(chat_id))
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disable_notification)
            {
                args.Disable_notification = disable_notification;
            }

            if (reply_to_message_id != default)
            {
                args.Reply_to_message_id = reply_to_message_id;
            }

            if (allow_sending_without_reply)
            {
                args.Allow_sending_without_reply = allow_sending_without_reply;
            }

            if (reply_markup != null)
            {
                args.Reply_markup = reply_markup;
            }

            return bot.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, long chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chat_id == default)
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disable_notification)
            {
                args.Disable_notification = disable_notification;
            }

            if (reply_to_message_id != default)
            {
                args.Reply_to_message_id = reply_to_message_id;
            }

            if (allow_sending_without_reply)
            {
                args.Allow_sending_without_reply = allow_sending_without_reply;
            }

            if (reply_markup != null)
            {
                args.Reply_markup = reply_markup;
            }

            return bot.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient bot, SendDiceArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, string chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(chat_id))
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disable_notification)
            {
                args.Disable_notification = disable_notification;
            }

            if (reply_to_message_id != default)
            {
                args.Reply_to_message_id = reply_to_message_id;
            }

            if (allow_sending_without_reply)
            {
                args.Allow_sending_without_reply = allow_sending_without_reply;
            }

            if (reply_markup != null)
            {
                args.Reply_markup = reply_markup;
            }

            return await bot.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, “🏀”, “⚽”, or “🎰”. Dice can have values 1-6 for “🎲” and “🎯”, values 1-5 for “🏀” and “⚽”, and values 1-64 for “🎰”. Defaults to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, long chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chat_id == default)
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
            {
                args.Emoji = emoji;
            }

            if (disable_notification)
            {
                args.Disable_notification = disable_notification;
            }

            if (reply_to_message_id != default)
            {
                args.Reply_to_message_id = reply_to_message_id;
            }

            if (allow_sending_without_reply)
            {
                args.Allow_sending_without_reply = allow_sending_without_reply;
            }

            if (reply_markup != null)
            {
                args.Reply_markup = reply_markup;
            }

            return await bot.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient bot, SendDiceArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
