using System;
using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class UniqueBonusHolder
	{
		[SerializeField]
		private UniqueBonusType _uniqueBonusType;

		[SerializeField]
		private AssetModuleHolder<BaseBuildingUpgradeModule> _uniqueBonusModules;

		[SerializeField]
		private BaseBuildingData _adjacentBuildingBonusTarget;

		[SerializeField]
		private InventoryItemData _trackedInventoryItem;

		[SerializeField]
		private int _amountPerIncrease;

		public UniqueBonusType UniqueBonusType => default(UniqueBonusType);

		public bool HasUniqueBonus => false;

		public AssetModuleHolder<BaseBuildingUpgradeModule> UniqueBonusModules => null;

		public BaseBuildingData AdjacentBuildingBonusTarget => null;

		public InventoryItemData TrackedInventoryItem => null;

		public int AmountPerIncrease => 0;

		public void Init(ScriptableObject parent)
		{
		}

		private bool ShowBuildingTarget()
		{
			return false;
		}
	}
}
