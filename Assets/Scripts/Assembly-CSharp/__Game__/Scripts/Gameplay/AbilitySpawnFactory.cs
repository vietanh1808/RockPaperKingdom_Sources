namespace __Game__.Scripts.Gameplay
{
	public class AbilitySpawnFactory
	{
		private readonly SingleSpawn _singleSpawn;

		private readonly AngleOffsetSpawn _angleOffsetSpawn;

		private readonly DirectTargetSpawn _directTargetSpawn;

		private readonly MultiShotSpawn _multiShotSpawn;

		private readonly AuraSpawn _auraSpawn;

		private readonly DelayedMultiShotSpawn _delayedMultiShotSpawn;

		private readonly RoundStartSpawn _roundStartSpawn;

		public AbilitySpawnFactory(SingleSpawn singleSpawn, AngleOffsetSpawn angleOffsetSpawn, DirectTargetSpawn directTargetSpawn, MultiShotSpawn multiShotSpawn, AuraSpawn auraSpawn, DelayedMultiShotSpawn delayedMultiShotSpawn, RoundStartSpawn roundStartSpawn)
		{
		}

		public IAbilitySpawn Get(AbilitySpawnType spawnType)
		{
			return null;
		}
	}
}
