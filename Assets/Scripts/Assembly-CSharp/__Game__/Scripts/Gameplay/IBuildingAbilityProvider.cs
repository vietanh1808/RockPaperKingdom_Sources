namespace __Game__.Scripts.Gameplay
{
	public interface IBuildingAbilityProvider
	{
		SharedAbility GetAbility(AbilityTargetType targetType);
	}
}
