// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountReleaseRequestMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class MountReleaseRequestMessage : NetworkMessage
	{
		public const uint Id = 5980;
		public override uint MessageId
		{
			get
			{
				return 5980;
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
