using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.Ballistic
{
	public class ExplodeOnDestinationReached : AbilityObjectComponent
	{
		[SerializeField]
		private Transform _explodeTransform;

		[SerializeField]
		private SoundBundleData _explosionSFX;

		private AbilityObject _abilityObject;

		private IDestinationReached _destinationReached;

		private float _radius;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void DestinationReachedReached()
		{
		}
	}
}
