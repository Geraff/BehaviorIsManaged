// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextRemoveElementMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameContextRemoveElementMessage : NetworkMessage
	{
		public const uint Id = 251;
		public override uint MessageId
		{
			get
			{
				return 251;
			}
		}
		
		public int id;
		
		public GameContextRemoveElementMessage()
		{
		}
		
		public GameContextRemoveElementMessage(int id)
		{
			this.id = id;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(id);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			id = reader.ReadInt();
		}
	}
}
