using System;
using Zenject;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayDebugSystem : IDisposable
	{
		private GameplayDebugSettings _gameplayDebugSettings;

		private StageSystem _stageSystem;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		private HeroSystem _heroSystem;

		private UnitCardSystem _unitCardSystem;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private GameplayUpgradesSystem _gameplayUpgradesSystem;

		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private WaveSystem _waveSystem;

		private GameplayStateMachine _gameplayStateMachine;

		private BuildingPlacementSystem _buildingPlacementSystem;

		private GridExpandSystem _gridExpandSystem;

		private RockPaperScissorsSystem _rpsSystem;

		private GameplayInventorySystem _gameplayInventorySystem;

		private GameplayConfig _gameplayConfig;

		private MysteryCardShopSystem _mysteryCardShopSystem;

		private BuildingPlacementSimulator _buildingPlacementSimulator;

		private RockPaperScissorsSimulator _rockPaperScissorsSimulator;

		private MysteryCardShopSimulator _mysteryCardShopSimulator;

		private int _totalBossChestSelectedCount;

		private bool IsDevelopmentEnvironment => false;

		public bool IsDebugMode => false;

		private bool CanUseSimulationSettings => false;

		[Inject]
		private void Inject(GameplayDebugSettings gameplayDebugSettings, StageSystem stageSystem, PlayerUpgradesSystem playerUpgradesSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, GameplayUpgradesSystem gameplayUpgradesSystem, GameplayUpgradesPresenter gameplayUpgradesPresenter, WaveSystem waveSystem, GameplayStateMachine gameplayStateMachine, BuildingPlacementSystem buildingPlacementSystem, GridExpandSystem gridExpandSystem, RockPaperScissorsSystem rpsSystem, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, MysteryCardShopSystem mysteryCardShopSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OverrideTimeScale()
		{
		}

		private void OverrideStageSettings()
		{
		}

		private void OverridePlayerSettings()
		{
		}

		private void OverrideUnitSettings()
		{
		}

		private void UnlockHeroUnitCards(HeroItemData heroItemData)
		{
		}

		private void UnlockExtraUnitCards()
		{
		}

		private void OverrideStrategySettings()
		{
		}

		private void OverrideSeed()
		{
		}

		private void OnFortuneRewardReceived()
		{
		}

		private void SelectUpgrade()
		{
		}

		private void ApplyRandomUpgrade()
		{
		}

		private void ApplyUpgrade(BaseGameplayUpgrade targetUpgrade)
		{
		}

		private void SelectBossChestUpgrade()
		{
		}

		private void ApplyRandomBossChestUpgrade()
		{
		}

		private void ApplyBossChestUpgrade(BaseGameplayUpgrade targetUpgrade)
		{
		}

		private void OverrideMaxWaveSettings()
		{
		}

		private void OnWaveStartedMaxWaveCheck()
		{
		}

		private void OverrideEnemyStatsMultiplier()
		{
		}

		private void InitializeBuildingPlacementSimulator()
		{
		}

		private void InitializeRockPaperScissorsSimulator()
		{
		}

		private void InitializeMysteryCardShopSimulator()
		{
		}
	}
}
