// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    public sealed partial class BotClient
    {
        private static HttpClient Client { get; set; }
        /// <summary>Set a httpclient for bot requets.</summary>
        /// <param name="client"><see cref="HttpClient"/> for http requets.</param>
        /// <exception cref="ArgumentNullException">Thrown when client is null.</exception>
        public static void SetHttpClient([Optional] HttpClient client)
        {
            Client = client ?? new HttpClient();
            if (!Client.DefaultRequestHeaders.Accept.Any(u => u.MediaType == "application/json"))
            {
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            if (!Client.DefaultRequestHeaders.Accept.Any(u => u.MediaType == "multipart/form-data"))
            {
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            }
        }
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        internal T RPC<T>(string method)
        {
            var rpc = RPCA<T>(method);
            try
            {
                return rpc.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, [Optional] CancellationToken cancellationToken)
        {
            var streamresponse = await GetRequestAsync($"bot{Token}/{method}", cancellationToken == null ? default : cancellationToken).ConfigureAwait(false);
            var response = await JsonSerializer.DeserializeAsync<BotResponse<T>>(streamresponse, cancellationToken: cancellationToken);
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description);
                }
            }
        }
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Serialize.</param>
        internal T RPC<T>(string method, object args, [Optional] JsonSerializerOptions options)
        {
            var rpc = RPCA<T>(method, args, options);
            try
            {
                return rpc.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        internal T RPC<T>(string method, Stream args)
        {
            var rpc = RPCA<T>(method, args);
            try
            {
                return rpc.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] CancellationToken cancellationToken)
        {
            var stream = await Tools.SerializeAsStreamAsync(args, serializeoptions)
                .ConfigureAwait(false);
            return await RPCA<T>(method, stream, cancellationToken)
                .ConfigureAwait(false);
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCA<T>(string method, Stream args, [Optional] CancellationToken cancellationToken)
        {
            var options = new JsonSerializerOptions();
            var stream = await PostRequestAsync($"bot{Token}/{method}", args, cancellationToken == null ? default : cancellationToken).ConfigureAwait(false);
            var response = await JsonSerializer.DeserializeAsync<BotResponse<T>>(stream, options, cancellationToken: cancellationToken);
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description);
                }
            }
        }
        /// <summary>RPC for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        internal T RPCF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions)
        {
            var rpcf = RPCAF<T>(method, args, serializeoptions, default);
            try
            {
                return rpcf.Result;
            }
            catch (AggregateException exp)
            {
                throw exp.InnerException;
            }
        }
        /// <summary>RPC async for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        internal async Task<T> RPCAF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] CancellationToken cancellationToken)
        {
            if (serializeoptions == default)
            {
                serializeoptions = new JsonSerializerOptions { IgnoreNullValues = true };
                serializeoptions.Converters.Add(new Tools.ReplyMarkupConverter());
                serializeoptions.Converters.Add(new Tools.InlineKeyboardMarkupConverter());
                serializeoptions.Converters.Add(new Tools.InputMediaJsonConverter());
            }
            var properties = args.GetType().GetProperties();
            using var content = new MultipartFormDataContent(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);
            foreach (var prop in properties)
            {
                var value = prop.GetValue(args);
                if (value != default)
                {
                    var jsonattribs = (JsonPropertyNameAttribute[])prop.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false);
                    if (jsonattribs.Length > 0)
                    {
                        var pname = jsonattribs[0].Name;
                        if (value.GetType() == typeof(InputFile))
                        {
                            var file = (InputFile)value;
                            content.Add(file.Content, pname, file.Filename);
                        }
                        else
                        {
                            if (value is string || value is bool || value.IsNumber())
                            {
                                var asjkasj = value.ToString();
                                var scon = new { Name = pname, Content = new StringContent(value.ToString(), Encoding.UTF8) };
                                content.Add(scon.Content, scon.Name);
                            }
                            else
                            {
                                string jvalue = JsonSerializer.Serialize(value, value.GetType(), serializeoptions);
                                var scon = new { Name = pname, Content = new StringContent(jvalue, Encoding.UTF8) };
                                content.Add(scon.Content, scon.Name);
                            }
                        }
                    }
                    else
                    {
                        if (args is IAttachFiles)
                        {
                            var attachfiles = (args as IAttachFiles).AttachFiles;
                            foreach (var attachfile in attachfiles)
                            {
                                content.Add(attachfile.File.Content, attachfile.Name, attachfile.File.Filename);
                            }
                        }
                    }
                }
            }
            var stream = await PostRequestAsyncFormData($"bot{Token}/{method}", content, cancellationToken == null ? default : cancellationToken).ConfigureAwait(false);
            var response = await JsonSerializer.DeserializeAsync<BotResponse<T>>(stream, cancellationToken: cancellationToken);
            content.Dispose();
            if (response.Ok == true)
            {
                return response.Result;
            }
            else
            {
                if (IgnoreBotExceptions)
                {
                    return default;
                }
                else
                {
                    throw new BotRequestException(response.ErrorCode, response.Description);
                }
            }
        }

        internal static async Task<Stream> PostRequestAsyncFormData(string path, MultipartFormDataContent args, CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.telegram.org/{path}")
            {
                Content = args
            };
            var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }
        internal static async Task<Stream> PostRequestAsync(string path, Stream args, CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, $"https://api.telegram.org/{path}")
            {
                Content = new StreamContent(args)
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }
        internal static async Task<Stream> GetRequestAsync(string path, CancellationToken cancellationToken)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.telegram.org/{path}");
            var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }
    }
}