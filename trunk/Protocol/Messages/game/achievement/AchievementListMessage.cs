// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AchievementListMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class AchievementListMessage : NetworkMessage
	{
		public const uint Id = 6205;
		public override uint MessageId
		{
			get
			{
				return 6205;
			}
		}
		
		public Types.Achievement[] startedAchievements;
		public short[] finishedAchievementsIds;
		
		public AchievementListMessage()
		{
		}
		
		public AchievementListMessage(Types.Achievement[] startedAchievements, short[] finishedAchievementsIds)
		{
			this.startedAchievements = startedAchievements;
			this.finishedAchievementsIds = finishedAchievementsIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)startedAchievements.Count());
			foreach (var entry in startedAchievements)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
			writer.WriteUShort((ushort)finishedAchievementsIds.Count());
			foreach (var entry in finishedAchievementsIds)
			{
				writer.WriteShort(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			startedAchievements = new Types.Achievement[limit];
			for (int i = 0; i < limit; i++)
			{
				(startedAchievements as Types.Achievement[])[i] = Types.ProtocolTypeManager.GetInstance<Types.Achievement>(reader.ReadShort());
				(startedAchievements as Types.Achievement[])[i].Deserialize(reader);
			}
			limit = reader.ReadUShort();
			finishedAchievementsIds = new short[limit];
			for (int i = 0; i < limit; i++)
			{
				(finishedAchievementsIds as short[])[i] = reader.ReadShort();
			}
		}
	}
}
