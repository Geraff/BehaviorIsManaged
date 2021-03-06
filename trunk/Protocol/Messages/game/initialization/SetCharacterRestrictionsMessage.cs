// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SetCharacterRestrictionsMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class SetCharacterRestrictionsMessage : NetworkMessage
	{
		public const uint Id = 170;
		public override uint MessageId
		{
			get
			{
				return 170;
			}
		}
		
		public Types.ActorRestrictionsInformations restrictions;
		
		public SetCharacterRestrictionsMessage()
		{
		}
		
		public SetCharacterRestrictionsMessage(Types.ActorRestrictionsInformations restrictions)
		{
			this.restrictions = restrictions;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			restrictions.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			restrictions = new Types.ActorRestrictionsInformations();
			restrictions.Deserialize(reader);
		}
	}
}
