using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TargetBeam : AbilityObjectComponent
	{
		[SerializeField]
		private Hovl_Laser2 _stream;

		[SerializeField]
		private float _beamLerpSpeed;

		[SerializeField]
		private float _hitPositionHeight;

		private AbilityObject _abilityObject;

		private UnitRepository _enemyRepository;

		private Vector3 _spawnPosition;

		private BaseUnit _targetUnit;

		private Vector3 _previousBeamPosition;

		private Vector3 _currentBeamPosition;

		private float _currentDuration;

		private float _tickInterval;

		private float _damage;

		private float _currentTickTime;

		private float _radius;

		private Collider[] _overlapEnemies;

		private float _castRange;

		public Vector3 CurrentBeamPosition => default(Vector3);

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void OnAbilityDeactivated()
		{
		}

		private void ReleaseBeam()
		{
		}

		private void SetupInitialStats()
		{
		}

		private void SetupTargetUnit()
		{
		}

		private void SetupInitialBeamPosition()
		{
		}

		private bool HasValidTarget()
		{
			return false;
		}

		private void FindNewTarget()
		{
		}

		private void TickDamage()
		{
		}

		private void UpdateBeamPosition()
		{
		}
	}
}
