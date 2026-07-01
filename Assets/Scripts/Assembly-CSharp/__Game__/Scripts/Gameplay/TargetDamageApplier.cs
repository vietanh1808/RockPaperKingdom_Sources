namespace __Game__.Scripts.Gameplay
{
	public class TargetDamageApplier : AbilityObjectComponent
	{
		private AbilityObject _abilityObject;

		private bool _hasApplied;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		public void ApplyDamage(IDamageable target)
		{
		}
	}
}
