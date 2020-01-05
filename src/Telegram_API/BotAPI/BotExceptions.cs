// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TelegramAPI
{
    /// <summary>Excepcion que se genera cuando una peticion hacia el api bot de telegram obtuvo una respuesta de error.</summary>
    public sealed class BotRequestException : Exception
    {
        ///<summary>Ok. False if error.</summary>
        public bool Ok { get; set; }
        ///<summary>Error code.</summary>
        public int Error_code { get; set; }
        ///<summary>Error description.</summary>
        public string Description { get; set; }
        /// <summary>JSON message that was sent in the request.</summary>
        public string Parameters { get; set; }
        internal BotRequestException(JObject result) : base(result["description"].Value<string>())
        {
            Ok = result["ok"].Value<bool>();
            Error_code = result["error_code"].Value<int>();
            Description = result["description"].Value<string>();
        }
        internal BotRequestException(string message, int errorcode) : base(message)
        {
            Ok = false;
            Error_code = errorcode;
            Description = message;
        }
        internal BotRequestException()
        {
            Ok = false;
        }
        internal BotRequestException(string message) : base(message)
        {
            Ok = false;
            Description = message;
        }
        internal BotRequestException(string message, Exception innerException) : base(message, innerException)
        {
            Ok = false;
            Description = message;
        }
    }
}
