using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class ArrowsRain : AbilityObjectComponent
	{
		[SerializeField]
		private ArrowsRainParticle _arrowPrefab;

		[SerializeField]
		private List<ArrowsRainParticle> _arrowParticles;

		[Header("Arrow Settings")]
		[SerializeField]
		private Vector3 _arrowOffset;

		[SerializeField]
		private float _hitRadius;

		[SerializeField]
		private float _arrowFallDuration;

		[SerializeField]
		private float _releaseDelay;

		private readonly List<ArrowsRainParticle> _activeArrows;

		private readonly Collider[] _hitResults;

		private ObjectPool<ArrowsRainParticle> _arrowsPool;

		private Vector3 _spawnCenter;

		private float _spawnRadius;

		private float _spawnDelay;

		private float _totalDuration;

		private float _tickInterval;

		private bool _isReleasing;

		private AbilityObject _abilityObject;

		private void Awake()
		{
		}

		private ArrowsRainParticle FactoryMethod()
		{
			return null;
		}

		private void Update()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void ReleaseArrows()
		{
		}

		private void SpawnArrow()
		{
		}

		private void Hit(Vector3 hitPosition)
		{
		}
	}
}
