using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class Meteor : AbilityObjectComponent
	{
		[SerializeField]
		private Vector3 _offset;

		[SerializeField]
		private float _fallDuration;

		[SerializeField]
		private float _releaseDelay;

		private readonly Collider[] _results;

		private Vector3 _hitPosition;

		private AbilityObject _abilityObject;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void RadiusDamage()
		{
		}

		private void PlayHitSound()
		{
		}

		private void SpawnEffect()
		{
		}
	}
}
