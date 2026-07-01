using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ExplodeOnHit : AbilityObjectComponent
	{
		private AbilityObject _abilityObject;

		private float _radius;

		private bool _hasTriggered;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
