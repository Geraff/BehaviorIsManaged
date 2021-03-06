// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterSelectedSuccessMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class CharacterSelectedSuccessMessage : NetworkMessage
	{
		public const uint Id = 153;
		public override uint MessageId
		{
			get
			{
				return 153;
			}
		}
		
		public Types.CharacterBaseInformations infos;
		
		public CharacterSelectedSuccessMessage()
		{
		}
		
		public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos)
		{
			this.infos = infos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			infos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			infos = new Types.CharacterBaseInformations();
			infos.Deserialize(reader);
		}
	}
}
