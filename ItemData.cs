using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MapleLibrary
{
    [Serializable]
    public class ItemData : ISerializable
    {
        public int ID { get; set; }
        public string action { get; set; }

        public ItemData() { }

        protected ItemData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            ID = (int)info.GetValue("ID", typeof(int));
            action = (string)info.GetValue("action", typeof(string));
        }

        [SecurityPermissionAttribute(SecurityAction.LinkDemand,
        Flags = SecurityPermissionFlag.SerializationFormatter)]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            info.AddValue("ID", ID);
            info.AddValue("action", action);
        }
    }
}
