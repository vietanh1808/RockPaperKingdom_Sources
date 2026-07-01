using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class TowerAttackObject : MonoBehaviour
	{
		[Header("Trajectory Settings")]
		[SerializeField]
		private float _minHeight;

		[SerializeField]
		private float _maxHeight;

		[SerializeField]
		private AnimationCurve _trajectoryCurve;

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

		[Header("Release Settings")]
		[SerializeField]
		private float _releaseDelayAfterDestination;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		private List<SpriteRenderer> _fadeInSprites;

		[Header("SFX")]
		[SerializeField]
		private SoundBundleData _arrowSound;

		private readonly Dictionary<SpriteRenderer, Color> _initialColors;

		private IObjectPool<TowerAttackObject> _pool;

		private float _attackDamage;

		private Vector3 _startPosition;

		private Vector3 _targetPosition;

		private Vector3 _previousBallisticPosition;

		private float _moveSpeed;

		private float _totalDistance;

		private float _maxHeightByDistance;

		private float _traveledDistance;

		private bool _readyToUse;

		public void Construct(IObjectPool<TowerAttackObject> pool)
		{
		}

		public void Configure(float attackDamage, Vector3 startPosition, Vector3 targetPosition, float moveSpeed, float range)
		{
		}

		public void ApplyDamage(IDamageable target, Vector3 hitPosition)
		{
		}

		private void InitializeColors()
		{
		}

		private void Update()
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

		private void UpdateBallisticRotating()
		{
		}

		private void DestinationReached()
		{
		}

		private void Release()
		{
		}

		private float GetMaxHeightByDistance(float range)
		{
			return 0f;
		}

		private float GetTravelProgress()
		{
			return 0f;
		}
	}
}
