namespace __Game__.Scripts.Gameplay
{
	public interface IAbilityOwnerAnimation
	{
		void SetPreparingCastStatus(bool isPreparingCast);

		void TriggerCast();
	}
}
