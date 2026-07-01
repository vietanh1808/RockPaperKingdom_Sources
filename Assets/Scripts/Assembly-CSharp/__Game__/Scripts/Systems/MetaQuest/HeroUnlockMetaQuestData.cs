using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class HeroUnlockMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private HeroItemData _requiredHero;

		public HeroItemData RequiredHero => null;
	}
}
