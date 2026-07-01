using UnityEngine;
using Zenject;
using __BattleSimulation__.Scripts.UI;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Environment;

namespace __BattleSimulation__.Scripts
{
	public class BattleSimulationSceneInstaller : MonoInstaller
	{
		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private Castle _castle;

		[SerializeField]
		private SlotsUnitSpawner _enemyUnitSpawner;

		[SerializeField]
		private SlotsUnitSpawner _playerUnitSpawner;

		[SerializeField]
		private EnvironmentBounds _environmentBounds;

		[Header("UI")]
		[SerializeField]
		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		[SerializeField]
		private UIDamageView _uiDamageView;

		[Header("Configs")]
		[SerializeField]
		private UpgradesConfig _upgradesConfig;

		[SerializeField]
		private BattleSimulationConfig _battleSimulationConfig;

		[Header("Collections")]
		[SerializeField]
		private GameplayUpgradeCollection _gameplayUpgradeCollection;

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
