// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'EmotePlayMassiveMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Messages
{
	public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
	{
		public const uint Id = 5691;
		public override uint MessageId
		{
			get
			{
				return 5691;
			}
		}
		
		public int[] actorIds;
		
		public EmotePlayMassiveMessage()
		{
		}
		
		public EmotePlayMassiveMessage(sbyte emoteId, double emoteStartTime, int[] actorIds)
			 : base(emoteId, emoteStartTime)
		{
			this.actorIds = actorIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)actorIds.Count());
			foreach (var entry in actorIds)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			actorIds = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(actorIds as int[])[i] = reader.ReadInt();
			}
		}
	}
}
