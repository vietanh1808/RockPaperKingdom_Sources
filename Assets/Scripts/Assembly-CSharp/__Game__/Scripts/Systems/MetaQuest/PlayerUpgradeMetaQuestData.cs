using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class PlayerUpgradeMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private int _requiredUpgradeIndex;

		public int RequiredUpgradeIndex => 0;
	}
}
