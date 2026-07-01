using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Gameplay.Arena.Enemy;
using __Game__.Scripts.Gameplay.Arena.StateMachine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Infrastructure
{
	public class ArenaSceneBootstrapper : MonoBehaviour
	{
		private PlayerGameplaySetup _playerGameplaySetup;

		private ArenaStateMachine _stateMachine;

		private GameplayUpgradesSystem _gameplayUpgradesSystem;

		private GameplayPlayerStatsSystem _gameplayPlayerStatsSystem;

		private RerollSystem _rerollSystem;

		private ArenaEnemyController _arenaEnemyController;

		private ArenaEnemySetup _arenaEnemySetup;

		private BuildingUnitSpawner _buildingUnitSpawner;

		private BuildingSlotGrid _buildingSlotGrid;

		private SoundsConfig _soundsConfig;

		private ArenaDebugSystem _arenaDebugSystem;

		private ArenaEnemyStaticStatSystem _arenaEnemyStaticStatSystem;

		[Inject]
		public void Inject(PlayerGameplaySetup playerGameplaySetup, ArenaStateMachine stateMachine, GameplayUpgradesSystem gameplayUpgradesSystem, GameplayPlayerStatsSystem gameplayPlayerStatsSystem, RerollSystem rerollSystem, ArenaEnemyController arenaEnemyController, ArenaEnemySetup arenaEnemySetup, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid, SoundsConfig soundsConfig, ArenaDebugSystem arenaDebugSystem, ArenaEnemyStaticStatSystem arenaEnemyStaticStatSystem)
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
