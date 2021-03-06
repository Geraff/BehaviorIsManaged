using System;
using System.Collections.Generic;
using BiM.Protocol.Tools;
namespace BiM.Protocol.Data
{
	[D2OClass("QuestStepRewards")]
	[Serializable]
	public class QuestStepRewards : IDataObject
	{
		private const String MODULE = "QuestStepRewards";
		public uint id;
		public uint stepId;
		public int levelMin;
		public int levelMax;
		public List<List<uint>> itemsReward;
		public List<uint> emotesReward;
		public List<uint> jobsReward;
		public List<uint> spellsReward;
	}
}
