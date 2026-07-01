namespace __Game__.Scripts.Gameplay
{
	public interface ITargetProvider
	{
		AbilityTargetLocation GetTargetPosition(Ability ability);

		bool HasTarget(Ability ability);
	}
}
