using __Game__.Scripts.Gameplay;

namespace __BattleSimulation__.Scripts
{
	public class BattleSimulationUnitSpawnerRepository
	{
		private readonly SlotsUnitSpawner _enemySpawner;

		private readonly SlotsUnitSpawner _playerSpawner;

		public BattleSimulationUnitSpawnerRepository(SlotsUnitSpawner enemySpawner, SlotsUnitSpawner playerSpawner)
		{
		}

		public SlotsUnitSpawner GetSpawner(UnitType unitType)
		{
			return null;
		}
	}
}
