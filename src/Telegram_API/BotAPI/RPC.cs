// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI
{
    public sealed partial class BotClient
    {
        /// <summary>HttpClient for bot requests.</summary>
        public static readonly HttpClient client = new HttpClient() { };
        /// <summary>RPC</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        internal T RPC<T>(string method, object args = null)
        {
            BotResponse<T> response;
            if (args != default)
            {
                var jsonargs = JsonConvert.SerializeObject(args, Formatting.Indented);
                var aresponse = PostRequestAsync<T>(TAPIurl, method, jsonargs); aresponse.Wait();
                response = aresponse.Result;
            }
            else
            {
                var aresponse = GetRequestAsync<T>(TAPIurl, method); aresponse.Wait();
                response = aresponse.Result;
            }
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
        internal async Task<T> RPCA<T>(string method, object args = null)
        {
            BotResponse<T> response;
            if (args != default)
            {
                var jsonargs = JsonConvert.SerializeObject(args, Formatting.Indented);
                response = await PostRequestAsync<T>(TAPIurl, method, jsonargs).ConfigureAwait(true);
            }
            else
            {
                response = await GetRequestAsync<T>(TAPIurl, method).ConfigureAwait(true);
            }
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
        internal T RPCF<T>(string method, object args)
        {
            var properties = args.GetType().GetProperties(); var prolist = new List<string>();
            var content = new MultipartFormDataContent(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);
            var attachprop = args.GetType().GetProperty("AttachFiles");
            AttachFile[] attachfiles = attachprop != default ? (AttachFile[])attachprop.GetValue(args) : default;
            foreach (var prop in properties)
            {
                InputFileAttribute[] attributes = (InputFileAttribute[])prop.GetCustomAttributes(typeof(InputFileAttribute), false);
                if (attributes.Length > 0)
                    if (prop.GetValue(args) != default)
                        if (prop.GetValue(args).GetType() == typeof(InputFile))
                        {
                            var file = (InputFile)prop.GetValue(args); prolist.Add(attributes[0].PropertyName);
                            content.Add(file.Content, attributes[0].PropertyName, file.Filename);
                        }
            }
            if (prolist.Count == 0 && attachfiles == default)
            {
                content.Dispose(); return RPC<T>(method, args);
            }
            var inputfiles = prolist.ToArray();
            var stringdata = JObject.FromObject(args).Properties().Where(p => !inputfiles.Any(u => u == p.Name)).Select(p => new { p.Name, Content = new StringContent(p.Value.ToString()) });
            foreach (var data in stringdata)
            {
                content.Add(data.Content, data.Name);
            }
            if (attachfiles != default)
            {
                foreach (AttachFile attachfile in attachfiles)
                {
                    content.Add(attachfile.File.Content, attachfile.Name, attachfile.File.Filename);
                }
            }
            var sTask = PostRequestAsyncFormData<T>(TAPIurl, method, content);
            var serializer = new JsonSerializer(); sTask.Wait(); content.Dispose();
            var response = sTask.Result;
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
        /// <summary>RPC async for files</summary>
        /// <typeparam name="T">return type.</typeparam>
        /// <param name="method">method name</param>
        /// <param name="args">parameters</param>
        internal async Task<T> RPCAF<T>(string method, object args)
        {
            var properties = args.GetType().GetProperties(); var prolist = new List<string>();
            var content = new MultipartFormDataContent(Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks);
            var attachprop = args.GetType().GetProperty("AttachFiles");
            AttachFile[] attachfiles = attachprop != default ? (AttachFile[])attachprop.GetValue(args) : default;
            foreach (var prop in properties)
            {
                InputFileAttribute[] attributes = (InputFileAttribute[])prop.GetCustomAttributes(typeof(InputFileAttribute), false);
                if (attributes.Length > 0)
                    if (prop.GetValue(args) != default)
                        if (prop.GetValue(args).GetType() == typeof(InputFile))
                        {
                            var file = (InputFile)prop.GetValue(args); prolist.Add(attributes[0].PropertyName);
                            content.Add(file.Content, attributes[0].PropertyName, file.Filename);
                        }
            }
            if (prolist.Count == 0 && attachfiles == default)
            {
                content.Dispose();
                return await RPCA<T>(method, args).ConfigureAwait(true);
            }
            var inputfiles = prolist.ToArray();
            var stringdata = JObject.FromObject(args).Properties().Where(p => !inputfiles.Any(u => u == p.Name)).Select(p => new { p.Name, Content = new StringContent(p.Value.ToString()) });
            foreach (var data in stringdata)
            {
                content.Add(data.Content, data.Name);
            }
            if (attachfiles != default)
            {
                foreach (AttachFile attachfile in attachfiles)
                {
                    content.Add(attachfile.File.Content, attachfile.Name, attachfile.File.Filename);
                }
            }
            var response = await PostRequestAsyncFormData<T>(TAPIurl, method, content).ConfigureAwait(false);
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
        internal static async Task<BotResponse<T>> PostRequestAsyncFormData<T>(string url, string method_name, MultipartFormDataContent args)
        {
            JsonSerializer serializer = new JsonSerializer();
            using var Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
            using var response = await Client.PostAsync(url + "/" + method_name, args).ConfigureAwait(true);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(true);
            using TextReader textReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(textReader);
            return serializer.Deserialize<BotResponse<T>>(jsonReader);
        }
        internal static async Task<BotResponse<T>> PostRequestAsync<T>(string url, string method_name, string args)
        {
            JsonSerializer serializer = new JsonSerializer();
            using var content = new StringContent(args, Encoding.UTF8, "application/json");
            using var response = await client.PostAsync(url + "/" + method_name, content).ConfigureAwait(true);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(true);
            using TextReader textReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(textReader);
            return serializer.Deserialize<BotResponse<T>>(jsonReader);
        }
        internal static async Task<BotResponse<T>> GetRequestAsync<T>(string url, string method_name)
        {
            JsonSerializer serializer = new JsonSerializer();
            using var response = await client.GetAsync(url + "/" + method_name).ConfigureAwait(true);
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(true);
            using TextReader textReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(textReader);
            return serializer.Deserialize<BotResponse<T>>(jsonReader);
        }
    }
}