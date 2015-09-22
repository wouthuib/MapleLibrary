using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MapleLibrary
{
    [Serializable]
    public class NPCData : ISerializable
    {
        public int ID { get; set; }
        public string action { get; set; }
        public int shopID { get; set; }
        public string player_name { get; set; }

        public NPCData() { }

        protected NPCData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            ID = (int)info.GetValue("ID", typeof(int));
            action = (string)info.GetValue("action", typeof(string));
            shopID = (int)info.GetValue("shopID", typeof(int));
            player_name = (string)info.GetValue("player_name", typeof(string));
        }

        [SecurityPermissionAttribute(SecurityAction.LinkDemand,
        Flags = SecurityPermissionFlag.SerializationFormatter)]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            info.AddValue("ID", ID);
            info.AddValue("action", action);
            info.AddValue("shopID", shopID);
            info.AddValue("player_name", player_name);
        }
    }
}
