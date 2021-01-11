// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient T, string name, int user_id)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteNumber("user_id", user_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setStickerSetThumb", stream);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient T, string name, int user_id, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteNumber("user_id", user_id);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setStickerSetThumb", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient T, string name, int user_id, string thumb)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            if (string.IsNullOrEmpty(thumb))
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteNumber("user_id", user_id);
            json.WriteString("thumb", thumb);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setStickerSetThumb", stream);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient T, string name, int user_id, string thumb, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            if (string.IsNullOrEmpty(thumb))
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteNumber("user_id", user_id);
            json.WriteString("thumb", thumb);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setStickerSetThumb", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient T, string name, int user_id, InputFile thumb)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            if (thumb == default)
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var args = new SetStickerSetThumbArgs { Name = name, User_id = user_id, Thumb = thumb };
            return T.RPCF<bool>("setStickerSetThumb", args);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="user_id">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient T, string name, int user_id, InputFile thumb, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (user_id == default)
            {
                throw new ArgumentNullException(nameof(user_id));
            }

            if (thumb == default)
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var args = new SetStickerSetThumbArgs { Name = name, User_id = user_id, Thumb = thumb };
            return await T.RPCAF<bool>("setStickerSetThumb", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient T, SetStickerSetThumbArgs args)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return T.RPCF<bool>("setStickerSetThumb", args);
            }
            else
            {
                return T.RPC<bool>("setStickerSetThumb", args);
            }
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient T, SetStickerSetThumbArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return await T.RPCAF<bool>("setStickerSetThumb", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await T.RPCA<bool>("setStickerSetThumb", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
