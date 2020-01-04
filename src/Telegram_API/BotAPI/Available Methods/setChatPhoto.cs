// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to set a new profile photo for the chat. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
        public static bool SetChatPhoto(this BotClient T, object chat_id, InputFile photo)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPCF<bool>("setChatPhoto", new SetChatPhotoArgs { Chat_id = chat_id, Photo = photo });
        }

        /// <summary>Use this method to set a new profile photo for the chat. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat.</param>
        /// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
        public static bool SetChatPhoto(this BotClient T, long chat_id, InputFile photo)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPCF<bool>("setChatPhoto", new SetChatPhotoArgs { Chat_id = chat_id, Photo = photo });
        }

        /// <summary>Use this method to set a new profile photo for the chat. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
        public static bool SetChatPhoto(this BotClient T, string chat_id, InputFile photo)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPCF<bool>("setChatPhoto", new SetChatPhotoArgs { Chat_id = chat_id, Photo = photo });
        }

        /// <summary>Use this method to set a new profile photo for the chat. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool SetChatPhoto(this BotClient T, SetChatPhotoArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<bool>("setChatPhoto", args);
        }
    }
}