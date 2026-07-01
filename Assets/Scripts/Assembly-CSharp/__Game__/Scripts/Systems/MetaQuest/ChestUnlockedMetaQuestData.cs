using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class ChestUnlockedMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private ChestData _requiredChest;

		public ChestData RequiredChest => null;
	}
}
