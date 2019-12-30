// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using TelegramAPI.Available_Types;
using TelegramAPI.Getting_updates;
using TelegramAPI.Inline_mode;
using TelegramAPI.Payments;

namespace TelegramAPI
{
    /// <summary>Provides pre-implemented properties and methods for creating a Telegram bot.</summary>
    public abstract class TBaseBot
    {
        /// <summary>Bot client for API Requets.</summary>
        protected BotClient TBot { get; private set; }
        /// <summary>True if the update search is active.</summary>
        public bool Running { get; private set; }
        private Task BGTask { get; set; }
        /// <summary>Initializes TBaseBot implementation</summary>
        /// <param name="accessToken">Token granted by BotFather. Required to access the Telegram bot API</param>
        protected TBaseBot(string accessToken) => TBot = new BotClient(accessToken);
        /// <summary>Starts a constant search for new updates. Use Stop() to stop it.<br/>
        /// If you are using a webhook, this will not work. Instead send the update to the OnUpdate() function.</summary>
        public void Start()
        {
            if (Running)
                return;
            BGTask = GetUpdateLoop();
        }
        /// <summary>Stops searching for updates, assuming it's active</summary>
        public void Stop()
        {
            if (BGTask != default)
            {
                if (!BGTask.IsCompleted)
                    Running = false;
                BGTask.Wait();
                BGTask.Dispose();
            }
        }
        private async Task GetUpdateLoop()
        {
            Running = true;
            await Task.Run(() =>
            {
                while (Running)
                {
                    var updates = TBot.GetUpdates();
                    if (updates.Length != 0)
                    {
                        foreach (var update in updates)
                        {
                            OnUpdate(update);
                            updates = TBot.GetUpdates(new GetUpdatesArgs { Offset = updates[0].Update_id + 1 });
                        }
                    }
                    else
                        updates = TBot.GetUpdates();
                }
            });
        }
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update"></param>
        public virtual void OnUpdate(Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    OnMessage(update.Message);
                    break;
                case UpdateType.Edited_message:
                    OnEditedMessage(update.Edited_message);
                    break;
                case UpdateType.Channel_post:
                    OnChannelPost(update.Channel_post);
                    break;
                case UpdateType.Edited_channel_post:
                    OnEditedChannelPost(update.Edited_channel_post);
                    break;
                case UpdateType.Inline_query:
                    OnInlineQuery(update.Inline_query);
                    break;
                case UpdateType.Chosen_inline_result:
                    OnChosenInlineResult(update.Chosen_inline_result);
                    break;
                case UpdateType.Callback_query:
                    OnCallbackQuery(update.Callback_query);
                    break;
                case UpdateType.Shipping_query:
                    OnShippingQuery(update.Shipping_query);
                    break;
                case UpdateType.Pre_checkout_query:
                    OnPreCheckoutQuery(update.Pre_checkout_query);
                    break;
                case UpdateType.Poll:
                    OnPoll(update.Poll);
                    break;
            }
        }
        //abstract methods
        /// <summary>Executes scheduled instructions for a message update.</summary>
        /// <param name="message">Message</param>
        protected abstract void OnMessage(Message message);
        /// <summary>Executes scheduled instructions for a edited message update.</summary>
        /// <param name="message">Edited message</param>
        protected abstract void OnEditedMessage(Message message);
        /// <summary>Executes scheduled instructions for a channel post update.</summary>
        /// <param name="message">Channel post</param>
        protected abstract void OnChannelPost(Message message);
        /// <summary>Executes scheduled instructions for a edited channel post update.</summary>
        /// <param name="message">Edited channel post</param>
        protected abstract void OnEditedChannelPost(Message message);
        /// <summary>Executes scheduled instructions for a inline query update.</summary>
        /// <param name="inlineQuery">Incoming inline query</param>
        protected abstract void OnInlineQuery(InlineQuery inlineQuery);
        /// <summary>Executes scheduled instructions for a inline result update.</summary>
        /// <param name="inlineResult">Incoming inline result</param>
        protected abstract void OnChosenInlineResult(ChosenInlineResult inlineResult);
        /// <summary>Executes scheduled instructions for a callback query update.</summary>
        /// <param name="callbackQuery">Incoming callback query</param>
        protected abstract void OnCallbackQuery(CallbackQuery callbackQuery);
        /// <summary>Executes scheduled instructions for a shipping query update.</summary>
        /// <param name="shippingQuery">Incoming shipping query</param>
        protected abstract void OnShippingQuery(ShippingQuery shippingQuery);
        /// <summary>Executes scheduled instructions for pre-checkout query update.</summary>
        /// <param name="preCheckoutQuery">Incoming pre-checkout query</param>
        protected abstract void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery);
        /// <summary>Executes scheduled instructions for a poll update.</summary>
        /// <param name="poll">poll</param>
        protected abstract void OnPoll(Poll poll);
    }
}
