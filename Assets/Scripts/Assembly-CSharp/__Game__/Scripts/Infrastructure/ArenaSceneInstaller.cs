using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Gameplay.Arena.Enemy;
using __Game__.Scripts.Gameplay.Arena.UI;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.Environment;

namespace __Game__.Scripts.Infrastructure
{
	public class ArenaSceneInstaller : MonoInstaller
	{
		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private CameraStateController _cameraStateController;

		[SerializeField]
		private Castle _castle;

		[SerializeField]
		private EnvironmentBounds _environmentBounds;

		[Header("Units Spawn")]
		[SerializeField]
		private SlotGridSpawnPatternsSettings _slotGridSpawnPatternsSettings;

		[SerializeField]
		private BuildingUnitSpawner _buildingUnitSpawner;

		[Header("Enemy")]
		[SerializeField]
		private ArenaEnemySetup _arenaEnemySetup;

		[Header("UI")]
		[SerializeField]
		private UIArenaSceneNavigation _uiArenaSceneNavigation;

		[SerializeField]
		private UIDamageView _uiDamageView;

		[SerializeField]
		private BuildingHoverController _buildingHoverController;

		[SerializeField]
		private UIBuildingStatChangeItem _statChangeItemPrefab;

		[Header("Coins")]
		[SerializeField]
		private GameplayCoinObjectManager _coinObjectManager;

		[Header("Configs")]
		[SerializeField]
		private UpgradesConfig _upgradesConfig;

		[SerializeField]
		private GameplayConfig _gameplayConfig;

		[SerializeField]
		private GridExpandConfig _gridExpandConfig;

		[SerializeField]
		private RerollConfig _rerollConfig;

		[SerializeField]
		private ArenaDebugConfig _arenaDebugConfig;

		[Header("Collections")]
		[SerializeField]
		private GameplayUpgradeCollection _gameplayUpgradeCollection;

		[SerializeField]
		private GameplayInventoryCollection _gameplayInventoryCollection;

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
	}
}
