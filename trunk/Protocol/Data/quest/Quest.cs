using System;
using System.Collections.Generic;
using BiM.Protocol.Tools;
namespace BiM.Protocol.Data
{
	[D2OClass("Quests")]
	[Serializable]
	public class Quest : IDataObject
	{
		private const String MODULE = "Quests";
		public uint id;
		public uint nameId;
		public List<uint> stepIds;
		public uint categoryId;
		public Boolean isRepeatable;
		public uint repeatType;
		public uint repeatLimit;
		public Boolean isDungeonQuest;
		public uint levelMin;
		public uint levelMax;
	}
}
