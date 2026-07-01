using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class HeroUpgradeMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private HeroItemData _requiredHero;

		[SerializeField]
		private int _requiredLevelIndex;

		public HeroItemData RequiredHero => null;

		public int RequiredLevelIndex => 0;
	}
}
