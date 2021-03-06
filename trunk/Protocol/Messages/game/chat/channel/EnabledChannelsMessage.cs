// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'EnabledChannelsMessage.xml' the '27/06/2012 15:54:59'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class EnabledChannelsMessage : NetworkMessage
	{
		public const uint Id = 892;
		public override uint MessageId
		{
			get
			{
				return 892;
			}
		}
		
		public sbyte[] channels;
		public sbyte[] disallowed;
		
		public EnabledChannelsMessage()
		{
		}
		
		public EnabledChannelsMessage(sbyte[] channels, sbyte[] disallowed)
		{
			this.channels = channels;
			this.disallowed = disallowed;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)channels.Count());
			foreach (var entry in channels)
			{
				writer.WriteSByte(entry);
			}
			writer.WriteUShort((ushort)disallowed.Count());
			foreach (var entry in disallowed)
			{
				writer.WriteSByte(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			channels = new sbyte[limit];
			for (int i = 0; i < limit; i++)
			{
				(channels as sbyte[])[i] = reader.ReadSByte();
			}
			limit = reader.ReadUShort();
			disallowed = new sbyte[limit];
			for (int i = 0; i < limit; i++)
			{
				(disallowed as sbyte[])[i] = reader.ReadSByte();
			}
		}
	}
}
