// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextQuitMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameContextQuitMessage : NetworkMessage
	{
		public const uint Id = 255;
		public override uint MessageId
		{
			get
			{
				return 255;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
