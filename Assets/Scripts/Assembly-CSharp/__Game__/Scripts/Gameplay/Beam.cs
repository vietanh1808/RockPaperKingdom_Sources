using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class Beam : AbilityObjectComponent
	{
		[SerializeField]
		private LineRenderer _beam;

		private Collider[] _overlapEnemies;

		private AbilityObject _abilityObject;

		private Vector3 _spawnPosition;

		private Vector3 _endPosition;

		private float _radius;

		private float _interval;

		private float _currentTickInterval;

		private float _castRange;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void UpdateBeam()
		{
		}

		private void TickDamage()
		{
		}

		private void Damage()
		{
		}
	}
}
