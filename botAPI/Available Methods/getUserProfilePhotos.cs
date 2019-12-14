using Newtonsoft.Json.Linq;
namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static Available_Types.UserProfilePhotos GetUserProfilePhotos(this BotClient T, int user_id) => T.RPC<Available_Types.UserProfilePhotos>("getUserProfilePhotos", new JObject { new JProperty("user_id", user_id) });
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static Available_Types.UserProfilePhotos GetUserProfilePhotos(this BotClient T, int user_id, uint offset) => T.RPC<Available_Types.UserProfilePhotos>("getUserProfilePhotos", new JObject { new JProperty("user_id", user_id), new JProperty("offset", offset) });
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <param name="limit">Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static Available_Types.UserProfilePhotos GetUserProfilePhotos(this BotClient T, int user_id, uint offset, ushort limit) => T.RPC<Available_Types.UserProfilePhotos>("getUserProfilePhotos", new JObject { new JProperty("user_id", user_id), new JProperty("offset", offset), new JProperty("limit", limit) });
    }
}