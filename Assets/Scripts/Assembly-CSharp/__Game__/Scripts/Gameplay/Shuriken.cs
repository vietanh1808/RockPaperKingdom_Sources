using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Environment;

namespace __Game__.Scripts.Gameplay
{
	[RequireComponent(typeof(Rigidbody))]
	public class Shuriken : AbilityObjectComponent
	{
		private const int MAX_WALL_BOUNCES = 3;

		[SerializeField]
		private float _speed;

		private ScreenEnvironmentBounds _screenEnvironmentBounds;

		private Rigidbody _rigidbody;

		private AbilityObject _abilityObject;

		private Vector3 _direction;

		private int _remainingPenetrations;

		private int _remainingBounces;

		[Inject]
		private void Inject(ScreenEnvironmentBounds screenEnvironmentBounds)
		{
		}

		private void Awake()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void BounceOffBounds(ref Vector3 position)
		{
		}
	}
}
