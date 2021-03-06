// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameEntityDispositionMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameEntityDispositionMessage : NetworkMessage
	{
		public const uint Id = 5693;
		public override uint MessageId
		{
			get
			{
				return 5693;
			}
		}
		
		public Types.IdentifiedEntityDispositionInformations disposition;
		
		public GameEntityDispositionMessage()
		{
		}
		
		public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
		{
			this.disposition = disposition;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			disposition.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			disposition = new Types.IdentifiedEntityDispositionInformations();
			disposition.Deserialize(reader);
		}
	}
}
