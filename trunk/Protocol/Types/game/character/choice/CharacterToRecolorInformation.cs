// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterToRecolorInformation.xml' the '27/06/2012 15:55:14'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Types
{
	public class CharacterToRecolorInformation
	{
		public const uint Id = 212;
		public virtual short TypeId
		{
			get
			{
				return 212;
			}
		}
		
		public int id;
		public int[] colors;
		
		public CharacterToRecolorInformation()
		{
		}
		
		public CharacterToRecolorInformation(int id, int[] colors)
		{
			this.id = id;
			this.colors = colors;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(id);
			writer.WriteUShort((ushort)colors.Count());
			foreach (var entry in colors)
			{
				writer.WriteInt(entry);
			}
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			id = reader.ReadInt();
			if ( id < 0 )
			{
				throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
			}
			int limit = reader.ReadUShort();
			colors = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(colors as int[])[i] = reader.ReadInt();
			}
		}
	}
}
