// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PaddockToSellListRequestMessage.xml' the '27/06/2012 15:55:04'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class PaddockToSellListRequestMessage : NetworkMessage
	{
		public const uint Id = 6141;
		public override uint MessageId
		{
			get
			{
				return 6141;
			}
		}
		
		public short pageIndex;
		
		public PaddockToSellListRequestMessage()
		{
		}
		
		public PaddockToSellListRequestMessage(short pageIndex)
		{
			this.pageIndex = pageIndex;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(pageIndex);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			pageIndex = reader.ReadShort();
			if ( pageIndex < 0 )
			{
				throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
			}
		}
	}
}
