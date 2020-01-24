// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    public sealed partial class BotClient
    {
        /// <summary>HttpClient for bot requests.</summary>
        public static readonly HttpClient client = new HttpClient() { };
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal T RPC<T>(string method, [Optional] JsonSerializerOptions options)
        {
            var rpc = RPCA<T>(method, options);
            rpc.Wait(); return rpc.Result;
        }
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="deserializeoptions">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal T RPC<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] JsonSerializerOptions deserializeoptions)
        {
            var rpc = RPCA<T>(method, args, serializeoptions, deserializeoptions);
            rpc.Wait(); return rpc.Result;
        }
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal T RPC<T>(string method, Stream args, [Optional] JsonSerializerOptions options)
        {
            var rpc = RPCA<T>(method, args, options);
            rpc.Wait(); return rpc.Result;
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal async Task<T> RPCA<T>(string method, [Optional] JsonSerializerOptions options)
        {
            if (options == default)
            {
                options = new JsonSerializerOptions();
            }
            BotResponse<T> response;
            response = await GetRequestAsync<T>(BotApiUrl, method, options).ConfigureAwait(false);
            if (response.Ok == true)
                return response.Result;
            else
            {
                if (IgnoreBotExceptions)
                    return default;
                else
                    throw new BotRequestException(response.Error_code, response.Description);
            }
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="deserializeoptions">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal async Task<T> RPCA<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] JsonSerializerOptions deserializeoptions)
        {
            if (serializeoptions == default)
            {
                serializeoptions = new JsonSerializerOptions { IgnoreNullValues = true };
                serializeoptions.Converters.Add(new JsonTools.ReplyMarkupConverter());
                serializeoptions.Converters.Add(new JsonTools.UintJsonConverter());
                serializeoptions.Converters.Add(new JsonTools.UshortJsonConverter());
            }
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, args.GetType(), serializeoptions).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await RPCA<T>(method, stream, deserializeoptions).ConfigureAwait(false);
        }
        /// <summary>RPC async</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="options">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal async Task<T> RPCA<T>(string method, Stream args, [Optional] JsonSerializerOptions options)
        {
            BotResponse<T> response;
            if (options == default)
            {
                options = new JsonSerializerOptions();
            }
            response = await PostRequestAsync<T>(BotApiUrl, method, args, options).ConfigureAwait(false);
            if (response.Ok == true)
                return response.Result;
            else
            {
                if (IgnoreBotExceptions)
                    return default;
                else
                    throw new BotRequestException(response.Error_code, response.Description);
            }
        }
        /// <summary>RPC for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="deserializeoptions">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal T RPCF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] JsonSerializerOptions deserializeoptions)
        {
            var rpcf = RPCAF<T>(method, args, serializeoptions, deserializeoptions);
            rpcf.Wait(); return rpcf.Result;
        }
        /// <summary>RPC async for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        /// <param name="serializeoptions">Provides options to be used with JsonSerializer.Serialize.</param>
        /// <param name="deserializeoptions">Provides options to be used with JsonSerializer.Deserialize.</param>
        internal async Task<T> RPCAF<T>(string method, object args, [Optional] JsonSerializerOptions serializeoptions, [Optional] JsonSerializerOptions deserializeoptions)
        {
            if (serializeoptions == default)
            {
                serializeoptions = new JsonSerializerOptions { IgnoreNullValues = true };
                serializeoptions.Converters.Add(new JsonTools.ReplyMarkupConverter());
                serializeoptions.Converters.Add(new JsonTools.InputMediaJsonConverter());
                serializeoptions.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            }
            if (deserializeoptions == default)
            {
                deserializeoptions = new JsonSerializerOptions { IgnoreNullValues = true };
            }
            var properties = args.GetType().GetProperties(); var prolist = new List<string>();
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
                        var attachprop = args.GetType().GetProperty("AttachFiles");
                        AttachFile[] attachfiles = attachprop == default ? default : (AttachFile[])attachprop.GetValue(args);
                        if (attachfiles != default)
                        {
                            foreach (AttachFile attachfile in attachfiles)
                            {
                                content.Add(attachfile.File.Content, attachfile.Name, attachfile.File.Filename);
                            }
                        }
                    }
                }
            }
            var response = await PostRequestAsyncFormData<T>(BotApiUrl, method, content, deserializeoptions).ConfigureAwait(false);
            content.Dispose();
            if (response.Ok == true)
                return response.Result;
            else
            {
                if (IgnoreBotExceptions)
                    return default;
                else
                    throw new BotRequestException(response.Error_code, response.Description);
            }
        }
        internal static async Task<BotResponse<T>> PostRequestAsyncFormData<T>(string url, string method_name, MultipartFormDataContent args, JsonSerializerOptions options)
        {
            using var Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            using var response = await Client.PostAsync(url + method_name, args).ConfigureAwait(false);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return await JsonSerializer.DeserializeAsync<BotResponse<T>>(stream, options);
        }
        internal static async Task<BotResponse<T>> PostRequestAsync<T>(string url, string method_name, Stream args, JsonSerializerOptions options)
        {
            using var content = new StreamContent(args);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using var response = await client.PostAsync(url + method_name, content).ConfigureAwait(false);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return await JsonSerializer.DeserializeAsync<BotResponse<T>>(stream, options);
        }
        internal static async Task<BotResponse<T>> GetRequestAsync<T>(string url, string method_name, JsonSerializerOptions options)
        {
            using var response = await client.GetAsync(url + method_name).ConfigureAwait(false);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return await JsonSerializer.DeserializeAsync<BotResponse<T>>(stream, options);
        }
    }
}