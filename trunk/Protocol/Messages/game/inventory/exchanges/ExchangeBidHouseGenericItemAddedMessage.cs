// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBidHouseGenericItemAddedMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
	{
		public const uint Id = 5947;
		public override uint MessageId
		{
			get
			{
				return 5947;
			}
		}
		
		public int objGenericId;
		
		public ExchangeBidHouseGenericItemAddedMessage()
		{
		}
		
		public ExchangeBidHouseGenericItemAddedMessage(int objGenericId)
		{
			this.objGenericId = objGenericId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objGenericId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objGenericId = reader.ReadInt();
		}
	}
}
