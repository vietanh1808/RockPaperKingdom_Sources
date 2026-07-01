using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ReleaseOnHit : AbilityObjectComponent
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
