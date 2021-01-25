// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Collections.Generic;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects that includes AttachFiles property.</summary>
    public interface IAttachFiles
    {
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public IEnumerable<AttachFile> AttachFiles { get; set; }
    }
}
