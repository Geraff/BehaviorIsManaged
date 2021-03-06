// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'StorageObjectUpdateMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class StorageObjectUpdateMessage : NetworkMessage
	{
		public const uint Id = 5647;
		public override uint MessageId
		{
			get
			{
				return 5647;
			}
		}
		
		public Types.ObjectItem @object;
		
		public StorageObjectUpdateMessage()
		{
		}
		
		public StorageObjectUpdateMessage(Types.ObjectItem @object)
		{
			this.@object = @object;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			@object.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			@object = new Types.ObjectItem();
			@object.Deserialize(reader);
		}
	}
}
