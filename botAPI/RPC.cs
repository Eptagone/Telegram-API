using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TelegramAPI
{
    public partial class BotClient
    {
        internal T RPC<T>(string Method, object args = null)
        {
            string url = TelegramBotAPIUrl;
            Task<string> Task;
            if (args != null)
                Task = PostRequestAsync(url, Token, Method, JsonConvert.SerializeObject(args, Formatting.Indented));
            else
                Task = GetRequestAsync(url, Token, Method);
            Task.Wait();
            var output = JObject.Parse(Task.Result);
            if (output["ok"].Value<bool>() == true)
                return output["result"].ToObject<T>();
            else
                throw new BotRequestException(output);
        }
        internal static async Task<string> PostRequestAsync(string url, string accessToken, string method_name, string args)
        {
            using (var Client = new HttpClient())
            {
                string AddressUrl = url + accessToken + "/" + method_name;
                var response = await Client.PostAsync(AddressUrl, new StringContent(args, Encoding.UTF8, "application/json"));
                return await response.Content.ReadAsStringAsync();
            }
        }
        internal static async Task<string> GetRequestAsync(string url, string accessToken, string method_name)
        {
            using (var Client = new HttpClient())
            {
                var response = await Client.GetAsync(url + accessToken + "/" + method_name);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}