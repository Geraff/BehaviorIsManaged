// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeShopStockStartedMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeShopStockStartedMessage : NetworkMessage
	{
		public const uint Id = 5910;
		public override uint MessageId
		{
			get
			{
				return 5910;
			}
		}
		
		public Types.ObjectItemToSell[] objectsInfos;
		
		public ExchangeShopStockStartedMessage()
		{
		}
		
		public ExchangeShopStockStartedMessage(Types.ObjectItemToSell[] objectsInfos)
		{
			this.objectsInfos = objectsInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectsInfos.Count());
			foreach (var entry in objectsInfos)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectsInfos = new Types.ObjectItemToSell[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectsInfos as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
				(objectsInfos as Types.ObjectItemToSell[])[i].Deserialize(reader);
			}
		}
	}
}
