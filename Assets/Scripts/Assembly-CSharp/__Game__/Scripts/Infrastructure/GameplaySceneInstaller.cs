using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.BossChest;
using __Game__.Scripts.Gameplay.CardPurchase;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.EnemyHint;
using __Game__.Scripts.Gameplay.Environment;
using __Game__.Scripts.Gameplay.Experience;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class GameplaySceneInstaller : MonoInstaller
	{
		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private CameraStateController _cameraStateController;

		[SerializeField]
		private Castle _castle;

		[SerializeField]
		private WaveSystem _waveSystem;

		[SerializeField]
		private EnvironmentBounds _environmentBounds;

		[Header("Units Spawn")]
		[SerializeField]
		private SlotGridSpawnPatternsSettings _slotGridSpawnPatternsSettings;

		[SerializeField]
		private SlotGridUnitSpawnerEnemy _slotGridUnitSpawnerEnemy;

		[SerializeField]
		private BuildingUnitSpawner _buildingUnitSpawner;

		[Header("Experience")]
		[SerializeField]
		private ExperienceObjectManager _experienceObjectManager;

		[Header("Boss Chest")]
		[SerializeField]
		private BossChestManager _bossChestManager;

		[Header("Coins")]
		[SerializeField]
		private GameplayCoinObjectManager _coinObjectManager;

		[Header("UI")]
		[SerializeField]
		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		[SerializeField]
		private UIGameplayTutorialsNavigation _uiGameplayTutorialsNavigation;

		[SerializeField]
		private UIDamageView _uiDamageView;

		[SerializeField]
		private BuildingHoverController _buildingHoverController;

		[SerializeField]
		private UIBuildingStatChangeItem _statChangeItemPrefab;

		[Header("Configs")]
		[SerializeField]
		private FortuneWheelConfig _fortuneWheelConfig;

		[SerializeField]
		private UpgradesConfig _upgradesConfig;

		[SerializeField]
		private CardPurchaseConfig _cardPurchaseConfig;

		[SerializeField]
		private GameplayConfig _gameplayConfig;

		[SerializeField]
		private GridExpandConfig _gridExpandConfig;

		[SerializeField]
		private RockPaperScissorsConfig _rockPaperScissorsConfig;

		[SerializeField]
		private MysteryCardShopConfig _mysteryCardShopConfig;

		[SerializeField]
		private RerollConfig _rerollConfig;

		[SerializeField]
		private EnemyHintConfig _enemyHintConfig;

		[Header("Collections")]
		[SerializeField]
		private GameplayUpgradeCollection _gameplayUpgradeCollection;

		[SerializeField]
		private GameplayInventoryCollection _gameplayInventoryCollection;

		[SerializeField]
		private BossChestUpgradeCollection _bossChestUpgradeCollection;

		[SerializeField]
		private BuildingDataCollection _buildingDataCollection;

		public override void InstallBindings()
		{
		}

		private void BindSceneObjects()
		{
		}

		private void BindSystems()
		{
		}

		private void BindGameplayComponents()
		{
		}

		private void BindUnits()
		{
		}

		private void BindUnitSpawns()
		{
		}

		private void BindAbilities()
		{
		}

		private void BindConfigs()
		{
		}

		private void BindCollections()
		{
		}

		private void BindExperience()
		{
		}

		private void BindBossChest()
		{
		}

		private void BindCoins()
		{
		}

		private void BindListeners()
		{
		}

		private void BindTutorials()
		{
		}

		private void BindDebug()
		{
		}
	}
}
