using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MapleLibrary
{
    [Serializable]
    public class HudData : ISerializable
    {
        public string action { get; set; }
        public int value { get; set; }
        public string player_name { get; set; }

        public HudData() { }

        protected HudData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            action = (string)info.GetValue("action", typeof(string));
            value = (int)info.GetValue("value", typeof(int));
            player_name = (string)info.GetValue("player_name", typeof(string));
        }

        [SecurityPermissionAttribute(SecurityAction.LinkDemand,
        Flags = SecurityPermissionFlag.SerializationFormatter)]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            info.AddValue("action", action);
            info.AddValue("value", value);
            info.AddValue("player_name", player_name);
        }
    }
}