﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Provides a Bot Template.</summary>
    [Obsolete("This class will be removed in future releases")]
    public class BotTemplate
    {
        /// <summary>Bot client for API Requets.</summary>
        public BotClient BotClient { get; private set; }

        /// <summary>Initializes TBaseBot implementation</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API</param>
        public BotTemplate(string accessToken)
        {
            BotClient = new BotClient(accessToken);
        }

        /// <summary>Initializes TBaseBot implementation</summary>
        /// <param name="botClient">Bot Client</param>
        public BotTemplate(BotClient botClient)
        {
            BotClient = botClient;
        }

        /// <summary>Start to get updates using polling.</summary>
        /// <param name="allowedUpdates">List of allowed updates.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        public virtual async void StartPollingAsync([Optional] string[] allowedUpdates, CancellationToken cancellationToken = default)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var updates = await BotClient
                            .GetUpdatesAsync(
                                allowedUpdates: allowedUpdates,
                                cancellationToken: cancellationToken)
                            .ConfigureAwait(false);
                    if (updates.Length > 0)
                    {
                    pending:
                        foreach (var update in updates)
                        {
                            OnUpdate(update, cancellationToken);
                        }

                        updates = await BotClient
                            .GetUpdatesAsync(
                                updates[updates.Length - 1].UpdateId + 1,
                                allowedUpdates: allowedUpdates,
                                cancellationToken: cancellationToken)
                            .ConfigureAwait(false);

                        if (updates.Length > 0)
                        {
                            goto pending;
                        }
                    }
                }
            }
            catch (OperationCanceledException) { }
            catch (BotRequestException exp)
            {
                OnBotException?.Invoke(this, new UpdateEventArgs<BotRequestException>(BotClient, exp, cancellationToken));
            }
        }

        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        public virtual void OnUpdate(Update update, [Optional] CancellationToken cancellationToken)
        {
            try
            {
                if (update == default)
                {
                    throw new ArgumentNullException(nameof(update));
                }
                switch (update.Type)
                {
                    case UpdateType.Message:
                        OnMessage?.Invoke(this, new UpdateEventArgs<Message>(BotClient, update, update.Message, cancellationToken));
                        break;
                    case UpdateType.EditedMessage:
                        OnEditedMessage?.Invoke(this, new UpdateEventArgs<Message>(BotClient, update, update.EditedMessage, cancellationToken));
                        break;
                    case UpdateType.ChannelPost:
                        OnChannelPost?.Invoke(this, new UpdateEventArgs<Message>(BotClient, update, update.ChannelPost, cancellationToken));
                        break;
                    case UpdateType.EditedChannelPost:
                        OnEditedChannelPost?.Invoke(this, new UpdateEventArgs<Message>(BotClient, update, update.EditedChannelPost, cancellationToken));
                        break;
                    case UpdateType.InlineQuery:
                        OnInlineQuery?.Invoke(this, new UpdateEventArgs<InlineQuery>(BotClient, update, update.InlineQuery, cancellationToken));
                        break;
                    case UpdateType.ChosenInlineResult:
                        OnChosenInlineResult?.Invoke(this, new UpdateEventArgs<ChosenInlineResult>(BotClient, update, update.ChosenInlineResult, cancellationToken));
                        break;
                    case UpdateType.CallbackQuery:
                        OnCallbackQuery?.Invoke(this, new UpdateEventArgs<CallbackQuery>(BotClient, update, update.CallbackQuery, cancellationToken));
                        break;
                    case UpdateType.ShippingQuery:
                        OnShippingQuery?.Invoke(this, new UpdateEventArgs<ShippingQuery>(BotClient, update, update.ShippingQuery, cancellationToken));
                        break;
                    case UpdateType.PreCheckoutQuery:
                        OnPreCheckoutQuery?.Invoke(this, new UpdateEventArgs<PreCheckoutQuery>(BotClient, update, update.PreCheckoutQuery, cancellationToken));
                        break;
                    case UpdateType.Poll:
                        OnPoll?.Invoke(this, new UpdateEventArgs<Poll>(BotClient, update, update.Poll, cancellationToken));
                        break;
                    case UpdateType.PollAnswer:
                        OnPollAnswer?.Invoke(this, new UpdateEventArgs<PollAnswer>(BotClient, update, update.PollAnswer, cancellationToken));
                        break;
                    case UpdateType.Unknown:
                    default:
                        throw new ArgumentException("The update parameter does not correspond to a valid update.", nameof(update));
                }
            }
            catch (BotRequestException exp)
            {
                OnBotException?.Invoke(this, new UpdateEventArgs<BotRequestException>(BotClient, update, exp, cancellationToken));
            }
            catch (Exception exp)
            {
                OnException?.Invoke(this, new UpdateEventArgs<Exception>(BotClient, update, exp, cancellationToken));
            }
        }

        /// <summary>Executes scheduled instructions for a message update.</summary>
        public event EventHandler<UpdateEventArgs<Message>> OnMessage;
        /// <summary>Executes scheduled instructions for a edited message update.</summary>
        public event EventHandler<UpdateEventArgs<Message>> OnEditedMessage;
        /// <summary>Executes scheduled instructions for a channel post update.</summary>
        public event EventHandler<UpdateEventArgs<Message>> OnChannelPost;
        /// <summary>Executes scheduled instructions for a edited channel post update.</summary>
        public event EventHandler<UpdateEventArgs<Message>> OnEditedChannelPost;
        /// <summary>Executes scheduled instructions for a inline query update.</summary>
        public event EventHandler<UpdateEventArgs<InlineQuery>> OnInlineQuery;
        /// <summary>Executes scheduled instructions for a inline result update.</summary>
        public event EventHandler<UpdateEventArgs<ChosenInlineResult>> OnChosenInlineResult;
        /// <summary>Executes scheduled instructions for a callback query update.</summary>
        public event EventHandler<UpdateEventArgs<CallbackQuery>> OnCallbackQuery;
        /// <summary>Executes scheduled instructions for a shipping query update.</summary>
        public event EventHandler<UpdateEventArgs<ShippingQuery>> OnShippingQuery;
        /// <summary>Executes scheduled instructions for pre-checkout query update.</summary>
        public event EventHandler<UpdateEventArgs<PreCheckoutQuery>> OnPreCheckoutQuery;
        /// <summary>Executes scheduled instructions for a poll update.</summary>
        public event EventHandler<UpdateEventArgs<Poll>> OnPoll;
        /// <summary>Executes scheduled instructions for a poll answer update.</summary>
        public event EventHandler<UpdateEventArgs<PollAnswer>> OnPollAnswer;
        /// <summary>Executes scheduled instructions for a bot exception.</summary>
        public event EventHandler<UpdateEventArgs<BotRequestException>> OnBotException;
        /// <summary>Executes scheduled instructions for a general exception.</summary>
        public event EventHandler<UpdateEventArgs<Exception>> OnException;
    }

    /// <summary>Update event args. Use with BotTemplate.</summary>
    /// <typeparam name="T">Event Type</typeparam>
    [Obsolete("This class will be removed in future releases")]
    public sealed class UpdateEventArgs<T>
    {

        internal UpdateEventArgs(BotClient bot, T updateResult, CancellationToken cancellationToken)
        {
            Bot = bot;
            EventParameter = updateResult;
            CancellationToken = cancellationToken;
        }

        internal UpdateEventArgs(BotClient bot, Update update, T updateResult, CancellationToken cancellationToken)
        {
            Bot = bot;
            Update = update;
            EventParameter = updateResult;
            CancellationToken = cancellationToken;
        }

        /// <summary>Bot Client</summary>
        public BotClient Bot { get; set; }
        /// <summary>Original update</summary>
        public Update Update { get; }
        /// <summary>Event Parameter</summary>
        public T EventParameter { get; }
        /// <summary>Cancelation Token for async tasks</summary>
        public CancellationToken CancellationToken { get; }
    }
}