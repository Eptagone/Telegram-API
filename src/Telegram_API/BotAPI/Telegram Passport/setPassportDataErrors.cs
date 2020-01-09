// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Telegram Passport</summary>
    public static partial class TelegramPassport
    {
        /// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
        /// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
        /// <param name="T">Bot Client</param>
        /// <param name="user_id">User identifier</param>
        /// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
        public static bool SetPassportDataErrors(this BotClient T, int user_id, PassportElementError[] errors)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("", new JObject { new JProperty("user_id", user_id), new JProperty("errors", errors) });
        }
        /// <summary>Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
        /// <para>Use this if the data submitted by the user doesn't satisfy the standards your service requires for any reason. For example, if a birthday date seems invalid, a submitted document is blurry, a scan shows evidence of tampering, etc. Supply some details in the error message to make sure the user knows how to correct the issues.</para></summary>
        /// <param name="T">Bot Client</param>
        /// <param name="user_id">User identifier</param>
        /// <param name="errors">An array of <see cref="PassportElementError"/> describing the errors</param>
        public static async Task<bool> SetPassportDataErrorsAsync(this BotClient T, int user_id, PassportElementError[] errors)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("", new JObject { new JProperty("user_id", user_id), new JProperty("errors", errors) }).ConfigureAwait(true);
        }
    }
}
