using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class DamageOnHitPiercing : AbilityObjectComponent
	{
		private AbilityObject _abilityObject;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
