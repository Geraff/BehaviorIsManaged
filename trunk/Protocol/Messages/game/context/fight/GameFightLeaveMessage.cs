// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightLeaveMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameFightLeaveMessage : NetworkMessage
	{
		public const uint Id = 721;
		public override uint MessageId
		{
			get
			{
				return 721;
			}
		}
		
		public int charId;
		
		public GameFightLeaveMessage()
		{
		}
		
		public GameFightLeaveMessage(int charId)
		{
			this.charId = charId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(charId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			charId = reader.ReadInt();
		}
	}
}
