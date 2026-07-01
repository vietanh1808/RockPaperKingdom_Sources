using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class TargetProviderFactory
	{
		private readonly AbilitySpawnPointTargetProvider _abilitySpawnPointTargetProvider;

		private readonly UnitPositionTargetProvider _unitPositionTargetProvider;

		private readonly FirstEnemyTargetProvider _firstEnemyTargetProvider;

		private readonly NoneTargetProvider _noneTargetProvider;

		private readonly PositionTargetProvider _positionTargetProvider;

		private readonly RandomEnemyTargetProvider _randomEnemyTargetProvider;

		private readonly RandomPositionProvider _randomPositionProvider;

		private readonly TargetHolderTargetProvider _targetHolderTargetProvider;

		private readonly MultishotFirstEnemyTargetProvider _multishotFirstEnemyTargetProvider;

		private readonly MultishotSecondRandomTargetProvider _multishotSecondRandomTargetProvider;

		private readonly DamageSourceTargetProvider _damageSourceTargetProvider;

		private readonly MultishotTargetHolderTargetProvider _multishotTargetHolderTargetProvider;

		private readonly ForwardMovementTargetProvider _forwardMovementTargetProvider;

		public TargetProviderFactory(DiContainer diContainer)
		{
		}

		public ITargetProvider Get(TargetProviderType targetProviderType)
		{
			return null;
		}
	}
}
