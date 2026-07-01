using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BeamBlast : AbilityObjectComponent
	{
		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private GameObject _particleObject;

		[SerializeField]
		private float _fadeInDuration;

		[SerializeField]
		private float _stayDuration;

		[SerializeField]
		private float _fadeOutDuration;

		[SerializeField]
		private float _particleTravelDuration;

		[SerializeField]
		private float _particleEndOffset;

		[SerializeField]
		private float _lingerDuration;

		[SerializeField]
		private float _scrollSpeed;

		[SerializeField]
		private bool _useDebugPositions;

		[SerializeField]
		private Vector3 _debugStartPosition;

		[SerializeField]
		private Vector3 _debugEndPosition;

		private static readonly int MAIN_TEX_OFFSET;

		private AbilityObject _abilityObject;

		private MaterialPropertyBlock _propertyBlock;

		private AbilityTargetLocation _targetLocation;

		private Vector3 _startPosition;

		private Vector3 _endPosition;

		private bool _canMoveParticle;

		private float _elapsedTime;

		private float _visualDuration;

		private float _totalDuration;

		private float _scrollOffset;

		private bool _isActive;

		private void Awake()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void SetupPositions()
		{
		}

		private void SetupLineRenderer()
		{
		}

		private void ApplyDamageToTarget()
		{
		}

		private void PlayHitSound()
		{
		}

		private void UpdateLineRendererAlpha()
		{
		}

		private float CalculateAlpha()
		{
			return 0f;
		}

		private void SetLineRendererAlpha(float alpha)
		{
		}

		private void UpdateMaterialScroll()
		{
		}

		private void UpdateParticlePosition()
		{
		}

		private void ResetParticlePosition()
		{
		}

		private void DebugPlay()
		{
		}
	}
}
