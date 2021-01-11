// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    ///<summary>Interface for <see cref="Location"/>.</summary>
    public interface ILocation
    {
        ///<summary>Longitude as defined by sender.</summary>
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        public float Latitude { get; set; }
        ///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
        public float Horizontal_accuracy { get; set; }
        ///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
        public uint Live_period { get; set; }
        ///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
        public ushort Heading { get; set; }
        ///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
        public uint Proximity_alert_radius { get; set; }
    }
}