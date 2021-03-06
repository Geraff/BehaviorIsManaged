// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightOptionToggleMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameFightOptionToggleMessage : NetworkMessage
	{
		public const uint Id = 707;
		public override uint MessageId
		{
			get
			{
				return 707;
			}
		}
		
		public sbyte option;
		
		public GameFightOptionToggleMessage()
		{
		}
		
		public GameFightOptionToggleMessage(sbyte option)
		{
			this.option = option;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(option);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			option = reader.ReadSByte();
			if ( option < 0 )
			{
				throw new Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
			}
		}
	}
}
