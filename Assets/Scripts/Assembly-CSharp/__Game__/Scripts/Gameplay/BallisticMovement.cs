using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BallisticMovement : AbilityObjectComponent, IDestinationReached
	{
		[Header("Movement")]
		[SerializeField]
		private float _moveSpeed;

		[Header("Height")]
		[SerializeField]
		private float _maxHeight;

		[SerializeField]
		private float _maxHeightDistance;

		[Header("Curves")]
		[SerializeField]
		private AnimationCurve _trajectoryCurve;

		[SerializeField]
		private AnimationCurve _scaleCurve;

		[Header("Rotation")]
		[SerializeField]
		private bool _useLookAtTarget;

		[Header("Direct Transforms")]
		[SerializeField]
		private Transform _directMovingTransform;

		[SerializeField]
		private Transform _directRotatingTransform;

		[Header("Ballistic Transforms")]
		[SerializeField]
		private Transform _ballisticMovingTransform;

		[SerializeField]
		private Transform _ballisticRotatingTransform;

		private Vector3 _startPosition;

		private AbilityTargetLocation _targetLocation;

		private float _totalDistance;

		private float _maxHeightByDistance;

		private float _traveledDistance;

		private bool _readyToUse;

		private bool _wasAtDestination;

		private Quaternion _initialRotation;

		private Quaternion _finalRotation;

		public event Action OnDestinationReached
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void Configure(Vector3 startPosition, Vector3 targetPosition)
		{
		}

		private void CalculateRotations()
		{
		}

		private void UpdateBallisticPosition()
		{
		}

		private void UpdateDirectPosition(float travelProgress)
		{
		}

		private void UpdateDirectRotating()
		{
		}

		private void UpdateBallisticHeight(float travelProgress)
		{
		}

		private void UpdateBallisticRotating(float travelProgress)
		{
		}

		private void UpdateBallisticScale(float travelProgress)
		{
		}

		private float GetMaxHeightByDistance()
		{
			return 0f;
		}

		private float GetTravelProgress(Vector3 currentTargetPosition)
		{
			return 0f;
		}
	}
}
