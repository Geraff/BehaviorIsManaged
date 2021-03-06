// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharactersListMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class CharactersListMessage : NetworkMessage
	{
		public const uint Id = 151;
		public override uint MessageId
		{
			get
			{
				return 151;
			}
		}
		
		public bool hasStartupActions;
		public Types.CharacterBaseInformations[] characters;
		
		public CharactersListMessage()
		{
		}
		
		public CharactersListMessage(bool hasStartupActions, Types.CharacterBaseInformations[] characters)
		{
			this.hasStartupActions = hasStartupActions;
			this.characters = characters;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(hasStartupActions);
			writer.WriteUShort((ushort)characters.Count());
			foreach (var entry in characters)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			hasStartupActions = reader.ReadBoolean();
			int limit = reader.ReadUShort();
			characters = new Types.CharacterBaseInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(characters as Types.CharacterBaseInformations[])[i] = Types.ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadShort());
				(characters as Types.CharacterBaseInformations[])[i].Deserialize(reader);
			}
		}
	}
}
