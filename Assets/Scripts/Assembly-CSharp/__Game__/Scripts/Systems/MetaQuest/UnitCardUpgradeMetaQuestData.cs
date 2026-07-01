using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class UnitCardUpgradeMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private UnitCardItemData _requiredUnitCard;

		[SerializeField]
		private int _requiredLevel;

		public UnitCardItemData RequiredUnitCard => null;

		public int RequiredLevel => 0;
	}
}
