using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleItemData : InventoryItemData
	{
		[SerializeField]
		private RarityType _rarity;

		[SerializeField]
		private InventoryItemData _material;

		[Header("Player Stats")]
		[SerializeField]
		private List<UpgradablePlayerStatData> _upgradePlayerStats;

		[Header("Modifiers")]
		[SerializeField]
		private CollectibleModifierLevelRequirements _levelRequirements;

		[SerializeField]
		private AssetModuleHolder<BaseModifier> _modifiers;

		[Header("Unlock Requirement")]
		[SerializeField]
		private CollectibleUnlockType _unlockType;

		[SerializeField]
		private int _stageRequirement;

		[SerializeField]
		private InventoryItemData _unlockInventoryItem;

		[SerializeField]
		private int _unlockInventoryItemAmount;

		[SerializeField]
		private int _dailyRewardDayRequirement;

		[Header("Level")]
		[SerializeField]
		private bool _isMaxLevel;

		public RarityType Rarity => default(RarityType);

		public InventoryItemData Material => null;

		public List<BaseModifier> Modifiers => null;

		public CollectibleModifierLevelRequirements LevelRequirements => null;

		public CollectibleUnlockType UnlockType => default(CollectibleUnlockType);

		public int StageRequirement => 0;

		public InventoryItemData UnlockInventoryItem => null;

		public int UnlockInventoryItemAmount => 0;

		public int DailyRewardDayRequirement => 0;

		public bool IsMaxLevel => false;

		private void OnEnable()
		{
		}

		public Dictionary<PlayerStatType, float> GetPlayerStats(int level)
		{
			return null;
		}

		public List<BaseModifier> GetUnlockedModifiers(int requiredLevel)
		{
			return null;
		}
	}
}
