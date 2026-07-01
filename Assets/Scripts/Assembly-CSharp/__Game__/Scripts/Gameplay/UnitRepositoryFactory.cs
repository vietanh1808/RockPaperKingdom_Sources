namespace __Game__.Scripts.Gameplay
{
	public class UnitRepositoryFactory
	{
		private readonly UnitRepository _enemyUnitRepository;

		private readonly UnitRepository _playerUnitRepository;

		public UnitRepository GetRepository(UnitType unitType)
		{
			return null;
		}

		public UnitRepository GetEnemyRepository(UnitType unitType)
		{
			return null;
		}
	}
}
