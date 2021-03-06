// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IgnoredAddRequestMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class IgnoredAddRequestMessage : NetworkMessage
	{
		public const uint Id = 5673;
		public override uint MessageId
		{
			get
			{
				return 5673;
			}
		}
		
		public string name;
		public bool session;
		
		public IgnoredAddRequestMessage()
		{
		}
		
		public IgnoredAddRequestMessage(string name, bool session)
		{
			this.name = name;
			this.session = session;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(name);
			writer.WriteBoolean(session);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			name = reader.ReadUTF();
			session = reader.ReadBoolean();
		}
	}
}
