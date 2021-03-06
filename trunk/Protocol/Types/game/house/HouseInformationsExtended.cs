// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HouseInformationsExtended.xml' the '27/06/2012 15:55:17'
using System;
using BiM.Core.IO;
using System.Collections.Generic;

namespace BiM.Protocol.Types
{
	public class HouseInformationsExtended : HouseInformations
	{
		public const uint Id = 112;
		public override short TypeId
		{
			get
			{
				return 112;
			}
		}
		
		public Types.GuildInformations guildInfo;
		
		public HouseInformationsExtended()
		{
		}
		
		public HouseInformationsExtended(bool isOnSale, bool isSaleLocked, int houseId, int[] doorsOnMap, string ownerName, short modelId, Types.GuildInformations guildInfo)
			 : base(isOnSale, isSaleLocked, houseId, doorsOnMap, ownerName, modelId)
		{
			this.guildInfo = guildInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			guildInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			guildInfo = new Types.GuildInformations();
			guildInfo.Deserialize(reader);
		}
	}
}
