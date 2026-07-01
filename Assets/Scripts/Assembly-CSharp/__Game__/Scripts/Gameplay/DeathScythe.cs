using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[RequireComponent(typeof(Rigidbody))]
	public class DeathScythe : AbilityObjectComponent
	{
		[SerializeField]
		private float _speed;

		[SerializeField]
		private float _extraDistance;

		[SerializeField]
		private float _slowdownDistance;

		[SerializeField]
		private float _minSpeed;

		[SerializeField]
		private float _arrivalThreshold;

		private Rigidbody _rigidbody;

		private AbilityObject _abilityObject;

		private Transform _ownerTransform;

		private Vector3 _lastOwnerPosition;

		private Vector3 _direction;

		private float _travelDistance;

		private float _distanceTraveled;

		private float _slowdownElapsed;

		private bool _isReturning;

		private bool _isSlowingDown;

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

		private void CacheOwnerPosition()
		{
		}

		private void UpdateForward()
		{
		}

		private void UpdateReturn()
		{
		}

		private float CalculateSpeed()
		{
			return 0f;
		}

		private static float SinInOutEase(float t)
		{
			return 0f;
		}
	}
}
