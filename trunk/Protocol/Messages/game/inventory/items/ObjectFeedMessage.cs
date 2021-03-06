// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectFeedMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectFeedMessage : NetworkMessage
	{
		public const uint Id = 6290;
		public override uint MessageId
		{
			get
			{
				return 6290;
			}
		}
		
		public int objectUID;
		public int foodUID;
		public short foodQuantity;
		
		public ObjectFeedMessage()
		{
		}
		
		public ObjectFeedMessage(int objectUID, int foodUID, short foodQuantity)
		{
			this.objectUID = objectUID;
			this.foodUID = foodUID;
			this.foodQuantity = foodQuantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectUID);
			writer.WriteInt(foodUID);
			writer.WriteShort(foodQuantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectUID = reader.ReadInt();
			if ( objectUID < 0 )
			{
				throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
			}
			foodUID = reader.ReadInt();
			if ( foodUID < 0 )
			{
				throw new Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
			}
			foodQuantity = reader.ReadShort();
			if ( foodQuantity < 0 )
			{
				throw new Exception("Forbidden value on foodQuantity = " + foodQuantity + ", it doesn't respect the following condition : foodQuantity < 0");
			}
		}
	}
}
