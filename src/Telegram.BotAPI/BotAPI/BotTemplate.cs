// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Getting_updates;
using Telegram.BotAPI.Inline_mode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Provides a Bot Template.</summary>
    public class BotTemplate
    {
        /// <summary>Bot client for API Requets.</summary>
        public BotClient BotClient { get; private set; }

        /// <summary>Initializes TBaseBot implementation</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API</param>
        public BotTemplate(string accessToken)
            => BotClient = new BotClient(accessToken);

        /// <summary>Initializes TBaseBot implementation</summary>
        /// <param name="botClient">Bot Client</param>
        public BotTemplate(BotClient botClient)
            => BotClient = botClient;

        /// <summary>Start to get updates using polling.</summary>
        /// <param name="allowed_updates">List of allowed updates.</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        public virtual async void StartPollingAsync([Optional] string[] allowed_updates, CancellationToken cancellationToken = default)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var updates = await BotClient
                            .GetUpdatesAsync(
                                allowed_updates: allowed_updates,
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
                                updates[updates.Length].Update_id + 1,
                                allowed_updates: allowed_updates,
                                cancellationToken: cancellationToken)
                            .ConfigureAwait(false);

                        if (updates.Length > 0)
                            goto pending;
                    }
                }
            }
            catch (OperationCanceledException) { }
            catch (BotRequestException exp)
            {
                OnBotException?.Invoke(this, new UpdateEventArgs<BotRequestException>(exp, cancellationToken));
            }
        }

        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        /// <param name="cancellationToken">Optional. Cancelation Token.</param>
        public virtual void OnUpdate(Update update, [Optional] CancellationToken cancellationToken)
        {
            if (update == default)
                throw new ArgumentNullException(nameof(update));
            try
            {
                switch (update.Type)
                {
                    case UpdateType.Message:
                        OnMessage?.Invoke(this, new UpdateEventArgs<Message>(update, update.Message, cancellationToken));
                        break;
                    case UpdateType.Edited_message:
                        OnEditedMessage?.Invoke(this, new UpdateEventArgs<Message>(update, update.Edited_message, cancellationToken));
                        break;
                    case UpdateType.Channel_post:
                        OnChannelPost?.Invoke(this, new UpdateEventArgs<Message>(update, update.Channel_post, cancellationToken));
                        break;
                    case UpdateType.Edited_channel_post:
                        OnEditedChannelPost?.Invoke(this, new UpdateEventArgs<Message>(update, update.Edited_channel_post, cancellationToken));
                        break;
                    case UpdateType.Inline_query:
                        OnInlineQuery?.Invoke(this, new UpdateEventArgs<InlineQuery>(update, update.Inline_query, cancellationToken));
                        break;
                    case UpdateType.Chosen_inline_result:
                        OnChosenInlineResult?.Invoke(this, new UpdateEventArgs<ChosenInlineResult>(update, update.Chosen_inline_result, cancellationToken));
                        break;
                    case UpdateType.Callback_query:
                        OnCallbackQuery?.Invoke(this, new UpdateEventArgs<CallbackQuery>(update, update.Callback_query, cancellationToken));
                        break;
                    case UpdateType.Shipping_query:
                        OnShippingQuery?.Invoke(this, new UpdateEventArgs<ShippingQuery>(update, update.Shipping_query, cancellationToken));
                        break;
                    case UpdateType.Pre_checkout_query:
                        OnPreCheckoutQuery?.Invoke(this, new UpdateEventArgs<PreCheckoutQuery>(update, update.Pre_checkout_query, cancellationToken));
                        break;
                    case UpdateType.Poll:
                        OnPoll?.Invoke(this, new UpdateEventArgs<Poll>(update, update.Poll, cancellationToken));
                        break;
                    case UpdateType.Unknown:
                    default:
                        throw new ArgumentException("The update parameter does not correspond to a valid update.", nameof(update));
                }
            }
            catch (BotRequestException exp)
            {
                OnBotException?.Invoke(this, new UpdateEventArgs<BotRequestException>(update, exp, cancellationToken));
            }
            catch (Exception exp)
            {
                OnException?.Invoke(this, new UpdateEventArgs<Exception>(update, exp, cancellationToken));
            }
        }

        /// <summary>Executes scheduled instructions for a message update.</summary>
        protected event EventHandler<UpdateEventArgs<Message>> OnMessage;
        /// <summary>Executes scheduled instructions for a edited message update.</summary>
        protected event EventHandler<UpdateEventArgs<Message>> OnEditedMessage;
        /// <summary>Executes scheduled instructions for a channel post update.</summary>
        protected event EventHandler<UpdateEventArgs<Message>> OnChannelPost;
        /// <summary>Executes scheduled instructions for a edited channel post update.</summary>
        protected event EventHandler<UpdateEventArgs<Message>> OnEditedChannelPost;
        /// <summary>Executes scheduled instructions for a inline query update.</summary>
        protected event EventHandler<UpdateEventArgs<InlineQuery>> OnInlineQuery;
        /// <summary>Executes scheduled instructions for a inline result update.</summary>
        protected event EventHandler<UpdateEventArgs<ChosenInlineResult>> OnChosenInlineResult;
        /// <summary>Executes scheduled instructions for a callback query update.</summary>
        protected event EventHandler<UpdateEventArgs<CallbackQuery>> OnCallbackQuery;
        /// <summary>Executes scheduled instructions for a shipping query update.</summary>
        protected event EventHandler<UpdateEventArgs<ShippingQuery>> OnShippingQuery;
        /// <summary>Executes scheduled instructions for pre-checkout query update.</summary>
        protected event EventHandler<UpdateEventArgs<PreCheckoutQuery>> OnPreCheckoutQuery;
        /// <summary>Executes scheduled instructions for a poll update.</summary>
        protected event EventHandler<UpdateEventArgs<Poll>> OnPoll;
        /// <summary>Executes scheduled instructions for a bot exception.</summary>
        protected event EventHandler<UpdateEventArgs<BotRequestException>> OnBotException;
        /// <summary>Executes scheduled instructions for a general exception.</summary>
        protected event EventHandler<UpdateEventArgs<Exception>> OnException;
    }

    /// <summary>Update event args. Use with BotTemplate.</summary>
    /// <typeparam name="T">Event Type</typeparam>
    public sealed class UpdateEventArgs<T>
    {

        internal UpdateEventArgs(T updateResult, CancellationToken cancellationToken)
        {
            EventParameter = updateResult;
            CancellationToken = cancellationToken;
        }

        internal UpdateEventArgs(Update update, T updateResult, CancellationToken cancellationToken)
        {
            Update = update;
            EventParameter = updateResult;
            CancellationToken = cancellationToken;
        }

        /// <summary>Original update</summary>
        public Update Update { get; }
        /// <summary>Event Parameter</summary>
        public T EventParameter { get; }
        /// <summary>Cancelation Token for async tasks</summary>
        public CancellationToken CancellationToken { get; }
    }
}
