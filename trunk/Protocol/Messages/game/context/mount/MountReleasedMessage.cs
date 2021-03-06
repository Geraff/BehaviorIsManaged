// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountReleasedMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class MountReleasedMessage : NetworkMessage
	{
		public const uint Id = 6308;
		public override uint MessageId
		{
			get
			{
				return 6308;
			}
		}
		
		public double mountId;
		
		public MountReleasedMessage()
		{
		}
		
		public MountReleasedMessage(double mountId)
		{
			this.mountId = mountId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(mountId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountId = reader.ReadDouble();
		}
	}
}
