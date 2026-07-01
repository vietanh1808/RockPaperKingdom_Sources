using System.Collections.Generic;
using __Game__.Scripts.Gameplay;

namespace __BattleSimulation__.Scripts.Controllers
{
	public class BattleSimulationController
	{
		private readonly BattleSimulationUnitSpawnerRepository _battleSimulationUnitSpawnerRepository;

		private readonly BattleSimulationSystem _battleSimulationSystem;

		private readonly UnitRepositoryFactory _unitRepositoryFactory;

		private readonly UnitPoolManager _unitPoolManager;

		public bool IsSimulationRunning { get; private set; }

		public BattleSimulationController(BattleSimulationUnitSpawnerRepository battleSimulationUnitSpawnerRepository, BattleSimulationSystem battleSimulationSystem, UnitRepositoryFactory unitRepositoryFactory, UnitPoolManager unitPoolManager)
		{
		}

		public void StartSimulation()
		{
		}

		public void StopSimulation()
		{
		}

		private void SpawnAllUnits()
		{
		}

		private void ActivateAllUnits()
		{
		}

		private void SpawnAttackerUnits()
		{
		}

		private void SpawnDefenderUnits()
		{
		}

		private void SpawnUnitsOfType(UnitBattleSimulationData unitBattleSimulationData, int amount, UnitType unitType)
		{
		}

		private void OverrideUnitStats(BaseUnit unit, UnitBattleSimulationData unitBattleSimulationData)
		{
		}

		private void ClearAllUnits()
		{
		}

		private void ReturnUnitsToPool(List<BaseUnit> units)
		{
		}
	}
}
