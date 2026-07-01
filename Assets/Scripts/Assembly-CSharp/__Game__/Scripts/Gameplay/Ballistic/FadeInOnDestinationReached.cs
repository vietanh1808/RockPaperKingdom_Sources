using UnityEngine;

namespace __Game__.Scripts.Gameplay.Ballistic
{
	public class FadeInOnDestinationReached : AbilityObjectComponent
	{
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		[SerializeField]
		private float _duration;

		private Color _initialColor;

		private int _initialSortingOrder;

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
