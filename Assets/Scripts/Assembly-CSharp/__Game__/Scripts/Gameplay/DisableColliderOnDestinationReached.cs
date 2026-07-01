using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class DisableColliderOnDestinationReached : AbilityObjectComponent
	{
		[SerializeField]
		private Collider _collider;

		private IDestinationReached _destinationReached;

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
