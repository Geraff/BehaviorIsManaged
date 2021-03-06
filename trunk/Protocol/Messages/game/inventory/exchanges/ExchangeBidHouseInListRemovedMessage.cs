// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBidHouseInListRemovedMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
	{
		public const uint Id = 5950;
		public override uint MessageId
		{
			get
			{
				return 5950;
			}
		}
		
		public int itemUID;
		
		public ExchangeBidHouseInListRemovedMessage()
		{
		}
		
		public ExchangeBidHouseInListRemovedMessage(int itemUID)
		{
			this.itemUID = itemUID;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(itemUID);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			itemUID = reader.ReadInt();
		}
	}
}
