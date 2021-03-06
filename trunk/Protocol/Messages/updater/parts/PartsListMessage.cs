// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartsListMessage.xml' the '27/06/2012 15:55:14'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class PartsListMessage : NetworkMessage
	{
		public const uint Id = 1502;
		public override uint MessageId
		{
			get
			{
				return 1502;
			}
		}
		
		public Types.ContentPart[] parts;
		
		public PartsListMessage()
		{
		}
		
		public PartsListMessage(Types.ContentPart[] parts)
		{
			this.parts = parts;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)parts.Count());
			foreach (var entry in parts)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			parts = new Types.ContentPart[limit];
			for (int i = 0; i < limit; i++)
			{
				(parts as Types.ContentPart[])[i] = new Types.ContentPart();
				(parts as Types.ContentPart[])[i].Deserialize(reader);
			}
		}
	}
}
