// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
        internal T RPC<T>(string method, object args = null)
        {
            Task<string> Task;
            if (args != null)
            {
                var jsonargs = JsonConvert.SerializeObject(args, Formatting.Indented);
                Task = PostRequestAsync(TAPIurl, method, jsonargs);
            }
            else
                Task = GetRequestAsync(TAPIurl, method);
            Task.Wait();
            var output = JObject.Parse(Task.Result);
            if (output["ok"].Value<bool>() == true)
                return output["result"].ToObject<T>();
            else
                throw new BotRequestException(output);
        }
        internal T RPCF<T>(string method, object args)
        {
            var properties = args.GetType().GetProperties();
            var prolist = new List<string>();
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
                            var file = (InputFile)prop.GetValue(args);
                            prolist.Add(attributes[0].PropertyName);
                            content.Add(file.Content, attributes[0].PropertyName, file.Filename);
                        }
            }
            if (prolist.Count == 0 && attachfiles == default)
            {
                content.Dispose();
                return RPC<T>(method, args);
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
            Task<string> Task;
            Task = PostRequestAsyncFormData(TAPIurl, method, content);
            Task.Wait(); content.Dispose();
            var output = JObject.Parse(Task.Result);
            if (output["ok"].Value<bool>() == true)
                return output["result"].ToObject<T>();
            else
                throw new BotRequestException(output);
        }
        internal static async Task<string> PostRequestAsyncFormData(string url, string method_name, MultipartFormDataContent args)
        {
            using (var Client = new HttpClient())
            {
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
                var addressurl = url + "/" + method_name;
                var response = await Client.PostAsync(addressurl, args).ConfigureAwait(true);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(true);
            }
        }
        internal static async Task<string> PostRequestAsync(string url, string method_name, string args)
        {
            using (var Client = new HttpClient())
            {
                string AddressUrl = url + "/" + method_name;
                var content = new StringContent(args, Encoding.UTF8, "application/json");
                var response = await Client.PostAsync(AddressUrl, content).ConfigureAwait(true);
                content.Dispose();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(true);
            }
        }
        internal static async Task<string> GetRequestAsync(string url, string method_name)
        {
            using (var Client = new HttpClient())
            {
                var response = await Client.GetAsync(url + "/" + method_name).ConfigureAwait(true);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(true);
            }
        }
    }
}