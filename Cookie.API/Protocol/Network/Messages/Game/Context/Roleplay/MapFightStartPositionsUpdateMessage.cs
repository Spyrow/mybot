﻿namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay
{
    using Types.Game.Context.Fight;
    using Utils.IO;

    public class MapFightStartPositionsUpdateMessage : NetworkMessage
    {
        public const ushort ProtocolId = 6716;
        public override ushort MessageID => ProtocolId;
        public double MapId { get; set; }
        public FightStartingPositions FightStartPositions { get; set; }

        public MapFightStartPositionsUpdateMessage(double mapId, FightStartingPositions fightStartPositions)
        {
            MapId = mapId;
            FightStartPositions = fightStartPositions;
        }

        public MapFightStartPositionsUpdateMessage() { }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(MapId);
            FightStartPositions.Serialize(writer);
        }

        public override void Deserialize(IDataReader reader)
        {
            MapId = reader.ReadDouble();
            FightStartPositions = new FightStartingPositions();
            FightStartPositions.Deserialize(reader);
        }

    }
}
