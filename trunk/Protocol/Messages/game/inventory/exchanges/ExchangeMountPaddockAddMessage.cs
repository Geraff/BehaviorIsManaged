// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountPaddockAddMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeMountPaddockAddMessage : NetworkMessage
	{
		public const uint Id = 6049;
		public override uint MessageId
		{
			get
			{
				return 6049;
			}
		}
		
		public Types.MountClientData mountDescription;
		
		public ExchangeMountPaddockAddMessage()
		{
		}
		
		public ExchangeMountPaddockAddMessage(Types.MountClientData mountDescription)
		{
			this.mountDescription = mountDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			mountDescription.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountDescription = new Types.MountClientData();
			mountDescription.Deserialize(reader);
		}
	}
}
