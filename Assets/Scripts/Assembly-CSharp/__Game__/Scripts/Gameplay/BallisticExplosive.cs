using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BallisticExplosive : AbilityObjectComponent
	{
		[SerializeField]
		private LayerMask _layerMask;

		[SerializeField]
		private float _speed;

		[SerializeField]
		private float _scaleByHeight;

		[SerializeField]
		private Transform _projectileTransform;

		private AbilityObject _abilityObject;

		private float _radius;

		private Vector3 _startPosition;

		private Vector3 _targetPosition;

		private bool _readyToUse;

		private float _totalDistance;

		private float _traveledDistance;

		private float _flightProgress;

		private Vector3 _initialScale;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateFlightPosition()
		{
		}

		private void UpdateProjectileScale()
		{
		}

		private void UpdateProjectileOffset()
		{
		}

		private void ApplyDamageTriggered()
		{
		}
	}
}
