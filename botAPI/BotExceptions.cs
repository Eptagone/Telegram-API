using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TelegramAPI
{
    /// <summary>Excepcion que se genera cuando una peticion hacia el api bot de telegram obtuvo una respuesta de error.</summary>
    public class BotRequestException : Exception
    {
        internal BotRequestException(JObject result)
        {
            Ok = result["ok"].Value<bool>();
            Error_code = result["error_code"].Value<int>();
            Description = result["description"].Value<string>();
        }
        ///<summary>Ok. False si existe error.</summary>
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }
        ///<summary>Codigo de error.</summary>
        [JsonProperty(PropertyName = "error_code")]
        public int Error_code { get; set; }
        ///<summary>Descripcion del error.</summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
