// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IgnoredListMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class IgnoredListMessage : NetworkMessage
	{
		public const uint Id = 5674;
		public override uint MessageId
		{
			get
			{
				return 5674;
			}
		}
		
		public Types.IgnoredInformations[] ignoredList;
		
		public IgnoredListMessage()
		{
		}
		
		public IgnoredListMessage(Types.IgnoredInformations[] ignoredList)
		{
			this.ignoredList = ignoredList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)ignoredList.Count());
			foreach (var entry in ignoredList)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			ignoredList = new Types.IgnoredInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(ignoredList as Types.IgnoredInformations[])[i] = Types.ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
				(ignoredList as Types.IgnoredInformations[])[i].Deserialize(reader);
			}
		}
	}
}
