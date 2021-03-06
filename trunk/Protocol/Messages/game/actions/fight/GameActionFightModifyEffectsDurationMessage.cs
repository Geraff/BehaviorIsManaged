// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightModifyEffectsDurationMessage.xml' the '27/06/2012 15:54:57'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
	{
		public const uint Id = 6304;
		public override uint MessageId
		{
			get
			{
				return 6304;
			}
		}
		
		public int targetId;
		public short delta;
		
		public GameActionFightModifyEffectsDurationMessage()
		{
		}
		
		public GameActionFightModifyEffectsDurationMessage(short actionId, int sourceId, int targetId, short delta)
			 : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.delta = delta;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(targetId);
			writer.WriteShort(delta);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			targetId = reader.ReadInt();
			delta = reader.ReadShort();
		}
	}
}
