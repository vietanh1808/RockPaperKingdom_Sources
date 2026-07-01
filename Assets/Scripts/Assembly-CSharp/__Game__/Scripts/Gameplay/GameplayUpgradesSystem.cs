using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayUpgradesSystem
	{
		private readonly List<BaseGameplayUpgrade> _rewardCollection;

		private readonly List<BaseGameplayUpgrade> _lastSelectedUpgradesRecord;

		private readonly HeroSystem _heroSystem;

		private readonly UpgradesConfig _upgradesConfig;

		private readonly GameplayUpgradeCollection _gameplayUpgradesCollection;

		private readonly StageSystem _stageSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private GameplayUpgradesRepository _upgradesRepository;

		private int _totalSelectedUpgradesCount;

		private int _requiredAmount;

		private int _currentRoundIndex;

		public SharedUnitRepository SharedUnitRepository { get; }

		public GameplayRewardSystem GameplayRewardSystem { get; }

		public BuildingPlacementSystem BuildingPlacementSystem { get; }

		public GameplayInventorySystem GameplayInventorySystem { get; }

		public Castle Castle { get; }

		public List<GameplayUpgradeSelection> ActiveUpgradesSelection { get; private set; }

		public List<BaseGameplayUpgrade> LastSelectedUpgradesRecord => null;

		public int TotalSelectedUpgradesCount => 0;

		public event Action<BaseGameplayUpgrade, UpgradeSource> OnUpgradeApplied
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected GameplayUpgradesSystem(UpgradesConfig upgradesConfig, SharedUnitRepository sharedUnitRepository, GameplayRewardSystem gameplayRewardSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem, GameplayUpgradeCollection gameplayUpgradesCollection, StageSystem stageSystem, BuildingPlacementSystem buildingPlacementSystem, GameplayInventorySystem gameplayInventorySystem, Castle castle)
		{
		}

		public void Initialize()
		{
		}

		public void RefreshThreeUpgrades()
		{
		}

		public void RerollUpgrades()
		{
		}

		private void RefreshThreeUpgradesExcluding(List<BaseGameplayUpgrade> excludedUpgrades)
		{
		}

		public void RefreshFirstUpgrades()
		{
		}

		private void SetupFirstUpgradesWithUnitSpawnConstraint(List<BaseGameplayUpgrade> availableUpgrades)
		{
		}

		private void SelectLowestRarityUnitSpawn(List<AddBuildingUpgrade> unitSpawnUpgrades)
		{
		}

		private void SelectRandomUnitSpawn(List<AddBuildingUpgrade> unitSpawnUpgrades)
		{
		}

		private void SelectNonUnitSpawnUpgrade(List<BaseGameplayUpgrade> nonUnitSpawnUpgrades, List<AddBuildingUpgrade> remainingUnitSpawns)
		{
		}

		private void SetupRegularUpgrades(List<BaseGameplayUpgrade> availableUpgrades)
		{
		}

		private void SetupRoundUpgrades(StageUpgradeRound upgradeRound)
		{
		}

		public void ApplyUpgrade(string guid, UpgradeSource source = UpgradeSource.Default)
		{
		}

		public void ApplyUpgrade(BaseGameplayUpgrade upgrade, UpgradeSource source = UpgradeSource.Default)
		{
		}

		public BaseGameplayUpgrade GetRandomUpgrade()
		{
			return null;
		}

		public IReadOnlyList<BaseGameplayUpgrade> GetAvailableUpgrades()
		{
			return null;
		}

		public void ClearLastSelectedUpgradesRecord()
		{
		}

		private RarityType GetUpgradeRarity(AddBuildingUpgrade upgrade)
		{
			return default(RarityType);
		}

		private void InitializeRegularUpgrades()
		{
		}
	}
}
