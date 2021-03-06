// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectGroundListAddedMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectGroundListAddedMessage : NetworkMessage
	{
		public const uint Id = 5925;
		public override uint MessageId
		{
			get
			{
				return 5925;
			}
		}
		
		public short[] cells;
		public int[] referenceIds;
		
		public ObjectGroundListAddedMessage()
		{
		}
		
		public ObjectGroundListAddedMessage(short[] cells, int[] referenceIds)
		{
			this.cells = cells;
			this.referenceIds = referenceIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)cells.Count());
			foreach (var entry in cells)
			{
				writer.WriteShort(entry);
			}
			writer.WriteUShort((ushort)referenceIds.Count());
			foreach (var entry in referenceIds)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			cells = new short[limit];
			for (int i = 0; i < limit; i++)
			{
				(cells as short[])[i] = reader.ReadShort();
			}
			limit = reader.ReadUShort();
			referenceIds = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(referenceIds as int[])[i] = reader.ReadInt();
			}
		}
	}
}
