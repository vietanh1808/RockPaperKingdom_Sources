namespace __Game__.Scripts.Gameplay
{
	public class NoneTargetProvider : ITargetProvider
	{
		public AbilityTargetLocation GetTargetPosition(Ability ability)
		{
			return null;
		}

		public bool HasTarget(Ability ability)
		{
			return false;
		}
	}
}
