﻿namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Npc
{
    using Utils.IO;

    public class NpcDialogCreationMessage : NetworkMessage
    {
        public const ushort ProtocolId = 5618;
        public override ushort MessageID => ProtocolId;
        public double MapId { get; set; }
        public int NpcId { get; set; }

        public NpcDialogCreationMessage(double mapId, int npcId)
        {
            MapId = mapId;
            NpcId = npcId;
        }

        public NpcDialogCreationMessage() { }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(MapId);
            writer.WriteInt(NpcId);
        }

        public override void Deserialize(IDataReader reader)
        {
            MapId = reader.ReadDouble();
            NpcId = reader.ReadInt();
        }

    }
}
