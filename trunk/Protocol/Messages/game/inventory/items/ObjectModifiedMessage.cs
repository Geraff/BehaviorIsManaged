// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectModifiedMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectModifiedMessage : NetworkMessage
	{
		public const uint Id = 3029;
		public override uint MessageId
		{
			get
			{
				return 3029;
			}
		}
		
		public Types.ObjectItem @object;
		
		public ObjectModifiedMessage()
		{
		}
		
		public ObjectModifiedMessage(Types.ObjectItem @object)
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
