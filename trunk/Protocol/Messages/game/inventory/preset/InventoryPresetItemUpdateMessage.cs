// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InventoryPresetItemUpdateMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class InventoryPresetItemUpdateMessage : NetworkMessage
	{
		public const uint Id = 6168;
		public override uint MessageId
		{
			get
			{
				return 6168;
			}
		}
		
		public sbyte presetId;
		public Types.PresetItem presetItem;
		
		public InventoryPresetItemUpdateMessage()
		{
		}
		
		public InventoryPresetItemUpdateMessage(sbyte presetId, Types.PresetItem presetItem)
		{
			this.presetId = presetId;
			this.presetItem = presetItem;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(presetId);
			presetItem.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			presetId = reader.ReadSByte();
			if ( presetId < 0 )
			{
				throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
			}
			presetItem = new Types.PresetItem();
			presetItem.Deserialize(reader);
		}
	}
}
