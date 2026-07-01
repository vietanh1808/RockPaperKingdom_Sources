using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class DamageOnHit : AbilityObjectComponent
	{
		private AbilityObject _abilityObject;

		private bool _hasTriggered;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
