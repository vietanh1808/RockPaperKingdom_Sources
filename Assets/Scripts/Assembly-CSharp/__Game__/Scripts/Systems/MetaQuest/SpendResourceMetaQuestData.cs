using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class SpendResourceMetaQuestData : BaseMetaQuestData
	{
		[SerializeField]
		private InventoryItemData _targetResource;

		[SerializeField]
		private int _requiredAmount;

		public InventoryItemData TargetResource => null;

		public int RequiredAmount => 0;
	}
}
