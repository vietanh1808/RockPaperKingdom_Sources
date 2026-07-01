using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ReleaseOnDestinationReached : AbilityObjectComponent
	{
		[SerializeField]
		private float _releaseDelay;

		private IDestinationReached _destinationReached;

		private AbilityObject _abilityObject;

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

		private void DestinationReached()
		{
		}
	}
}
