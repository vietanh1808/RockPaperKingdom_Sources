using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;
using __Game__.Scripts.Systems.MetaQuest;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Infrastructure
{
	public class ProjectDataInstaller : MonoInstaller
	{
		[Header("Configs")]
		[SerializeField]
		private SoundsConfig _soundsConfig;

		[SerializeField]
		private EnergyConfig _energyConfig;

		[SerializeField]
		private RarityConfig _rarityConfig;

		[SerializeField]
		private PlayerStatConfig _playerStatConfig;

		[SerializeField]
		private EquipmentConfig _equipmentConfig;

		[SerializeField]
		private HeroConfig _heroConfig;

		[SerializeField]
		private UnitCardConfig _unitCardConfig;

		[SerializeField]
		private PurchaseButtonConfig _purchaseButtonConfig;

		[SerializeField]
		private PlayerLevelUpConfig _playerLevelUpConfig;

		[SerializeField]
		private DailyRewardsConfig _dailyRewardsConfig;

		[SerializeField]
		private PatrolRewardsConfig _patrolRewardsConfig;

		[SerializeField]
		private SpeedUpConfig _speedUpConfig;

		[SerializeField]
		private PlayerUpgradesConfig _playerUpgradesConfig;

		[SerializeField]
		private FeatureUnlockConfig _featureUnlockConfig;

		[SerializeField]
		private WavesConfig _wavesConfig;

		[SerializeField]
		private MetaQuestConfig _metaQuestConfig;

		[SerializeField]
		private AppReviewConfig _appReviewConfig;

		[SerializeField]
		private ArenaConfig _arenaConfig;

		[SerializeField]
		private TalentCollectionConfig _talentCollectionConfig;

		[SerializeField]
		private DailyStreakQuestConfig _dailyStreakQuestConfig;

		[SerializeField]
		private AdsConfig _adsConfig;

		[Header("Collections")]
		[SerializeField]
		private InventoryCollection _inventoryCollection;

		[SerializeField]
		private PlayerStatInfoCollection _playerStatInfoCollection;

		[SerializeField]
		private StagesCollection _stagesCollection;

		[SerializeField]
		private ProductCollection _productCollection;

		[SerializeField]
		private PurchaseCollection _purchaseCollection;

		[SerializeField]
		private OffersConfig _offersConfig;

		public override void InstallBindings()
		{
		}

		private void BindConfigs()
		{
		}

		private void BindCollections()
		{
		}
	}
}
