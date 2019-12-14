using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    ///<summary>This object describes the position on faces where a mask should be placed by default.</summary>
    public class MaskPosition
    {
        ///<summary>The part of the face relative to which the mask should be placed. One of “forehead”, “eyes”, “mouth”, or “chin”.</summary>
        [JsonProperty(PropertyName = "point", Required = Required.Always)]
        public string Point { get; set; }
        ///<summary>Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. For example, choosing -1.0 will place mask just to the left of the default mask position.</summary>
        [JsonProperty(PropertyName = "x_shift", Required = Required.Always)]
        public float X_shift { get; set; }
        ///<summary>Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. For example, 1.0 will place the mask just below the default mask position.</summary>
        [JsonProperty(PropertyName = "y_shift", Required = Required.Always)]
        public float Y_shift { get; set; }
        ///<summary>Mask scaling coefficient. For example, 2.0 means double size.</summary>
        [JsonProperty(PropertyName = "scale", Required = Required.Always)]
        public float Scale { get; set; }
    }
}