﻿namespace Cookie.API.Protocol.Network.Messages.Debug
{
    using Utils.IO;

    public class DebugInClientMessage : NetworkMessage
    {
        public const ushort ProtocolId = 6028;
        public override ushort MessageID => ProtocolId;
        public byte Level { get; set; }
        public string Message { get; set; }

        public DebugInClientMessage(byte level, string message)
        {
            Level = level;
            Message = message;
        }

        public DebugInClientMessage() { }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(Level);
            writer.WriteUTF(Message);
        }

        public override void Deserialize(IDataReader reader)
        {
            Level = reader.ReadByte();
            Message = reader.ReadUTF();
        }

    }
}
