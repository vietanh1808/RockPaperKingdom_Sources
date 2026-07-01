using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_FeatureUnlock", menuName = "TapHub/Features/Feature Unlock Config")]
	public class FeatureUnlockConfig : ScriptableObject
	{
		[SerializeField]
		private FeatureItemData _stageChestFeature;

		[SerializeField]
		private FeatureItemData _shopFeature;

		[SerializeField]
		private FeatureItemData _inventoryFeature;

		[SerializeField]
		private FeatureItemData _playerUpgradesFeature;

		[SerializeField]
		private FeatureItemData _dailyRewardsFeature;

		[SerializeField]
		private FeatureItemData _patrolRewardsFeature;

		[SerializeField]
		private FeatureItemData _equipmentUpgrades;

		[Header("Heroes")]
		[SerializeField]
		private FeatureItemData _heroFeature;

		[SerializeField]
		private FeatureItemData _heroUpgrades;

		[SerializeField]
		private FeatureItemData _heroSelection;

		[SerializeField]
		private FeatureItemData _heroCardsTutorial;

		[Header("Unit Cards")]
		[SerializeField]
		private FeatureItemData _unitCardUpgrades;

		[Header("LiveOps")]
		[SerializeField]
		private FeatureItemData _dailyStreakQuestFeature;

		[Header("PvP Arena")]
		[SerializeField]
		private FeatureItemData _pvpArenaFeature;

		[Header("Hard Mode")]
		[SerializeField]
		private FeatureItemData _hardModeFeature;

		[SerializeField]
		private List<FeatureItemData> _collection;

		public FeatureItemData StageChestFeature => null;

		public FeatureItemData ShopFeature => null;

		public FeatureItemData InventoryFeature => null;

		public FeatureItemData PlayerUpgradesFeature => null;

		public FeatureItemData DailyRewardsFeature => null;

		public FeatureItemData PatrolRewardsFeature => null;

		public FeatureItemData EquipmentUpgrades => null;

		public FeatureItemData HeroFeature => null;

		public FeatureItemData HeroUpgrades => null;

		public FeatureItemData HeroSelection => null;

		public FeatureItemData HeroCardsTutorial => null;

		public FeatureItemData UnitCardUpgrades => null;

		public FeatureItemData DailyStreakQuestFeature => null;

		public FeatureItemData PvpArenaFeature => null;

		public FeatureItemData HardModeFeature => null;

		public List<FeatureItemData> Collection => null;
	}
}
