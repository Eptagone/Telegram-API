// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, or “🏀”. Dice can have values 1-6 for “🎲” and “🎯”, and values 1-5 for “🏀”. Defauts to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient T, string chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (string.IsNullOrEmpty(chat_id))
                throw new ArgumentNullException(nameof(chat_id));
            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
                args.Emoji = emoji;
            if (disable_notification != default)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != null)
                args.Reply_markup = reply_markup;
            return T.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, or “🏀”. Dice can have values 1-6 for “🎲” and “🎯”, and values 1-5 for “🏀”. Defauts to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient T, long chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (chat_id == default)
                throw new ArgumentNullException(nameof(chat_id));
            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
                args.Emoji = emoji;
            if (disable_notification != default)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != null)
                args.Reply_markup = reply_markup;
            return T.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDice(this BotClient T, SendDiceArgs args)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (args == default)
                throw new ArgumentNullException(nameof(args));
            return T.RPC<Message>("sendDice", args);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, or “🏀”. Dice can have values 1-6 for “🎲” and “🎯”, and values 1-5 for “🏀”. Defauts to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient T, string chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (string.IsNullOrEmpty(chat_id))
                throw new ArgumentNullException(nameof(chat_id));
            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
                args.Emoji = emoji;
            if (disable_notification != default)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != null)
                args.Reply_markup = reply_markup;
            return await T.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="emoji">Emoji on which the dice throw animation is based. Currently, must be one of “🎲”, “🎯”, or “🏀”. Dice can have values 1-6 for “🎲” and “🎯”, and values 1-5 for “🏀”. Defauts to “🎲”.</param>
        /// <param name="disable_notification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="reply_markup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient T, long chat_id, [Optional] string emoji, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (chat_id == default)
                throw new ArgumentNullException(nameof(chat_id));
            var args = new SendDiceArgs
            {
                Chat_id = chat_id
            };
            if (!string.IsNullOrEmpty(emoji))
                args.Emoji = emoji;
            if (disable_notification != default)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != null)
                args.Reply_markup = reply_markup;
            return await T.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send a dice, which will have a random value from 1 to 6. On success, the sent Message is returned. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDiceAsync(this BotClient T, SendDiceArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (args == default)
                throw new ArgumentNullException(nameof(args));
            return await T.RPCA<Message>("sendDice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
