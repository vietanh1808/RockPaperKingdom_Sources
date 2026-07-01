using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.BossChest;
using __Game__.Scripts.Gameplay.Listeners;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Infrastructure
{
	public class GameplaySceneBootstrapper : MonoBehaviour
	{
		private LevelPrefabLoader _levelPrefabLoader;

		private PlayerGameplaySetup _playerGameplaySetup;

		private WaveSystem _waveSystem;

		private GameplayStateMachine _stateMachine;

		private GameplaySettingsListener _gameplaySettingsListener;

		private RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private RestoreGameplayProgressSystem _restoreGameplayProgressSystem;

		private GameplayDebugSystem _gameplayDebugSystem;

		private GameplayLevelSystem _gameplayLevelSystem;

		private GameplayUpgradesSystem _gameplayUpgradesSystem;

		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private GameOverListener _gameOverListener;

		private SoundsConfig _soundsConfig;

		private SpeedUpGameplaySystem _speedUpGameplaySystem;

		private GameplayPlayerStatsSystem _gameplayPlayerStatsSystem;

		private BuildingRepository _buildingRepository;

		private BossChestUpgradeSystem _bossChestUpgradeSystem;

		private RerollSystem _rerollSystem;

		private BuildingUnitSpawner _buildingUnitSpawner;

		private BuildingSlotGrid _buildingSlotGrid;

		[Inject]
		public void Inject(LevelPrefabLoader levelPrefabLoader, PlayerGameplaySetup playerGameplaySetup, WaveSystem waveSystem, GameplayLevelSystem gameplayLevelSystem, GameplayUpgradesSystem gameplayUpgradesSystem, GameplayUpgradesPresenter gameplayUpgradesPresenter, GameplayDebugSystem gameplayDebugSystem, GameplayStateMachine stateMachine, GameplaySettingsListener gameplaySettingsListener, RestoreGameplayRuntimeData restoreGameplayRuntimeData, RestoreGameplayProgressSystem restoreGameplayProgressSystem, GameOverListener gameOverListener, SoundsConfig soundsConfig, SpeedUpGameplaySystem speedUpGameplaySystem, GameplayPlayerStatsSystem gameplayPlayerStatsSystem, BuildingRepository buildingRepository, BossChestUpgradeSystem bossChestUpgradeSystem, RerollSystem rerollSystem, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}
	}
}
