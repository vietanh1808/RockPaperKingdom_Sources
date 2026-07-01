using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class DamageTick : AbilityObjectComponent
	{
		private readonly Collider[] _results;

		private AbilityObject _abilityObject;

		private float _interval;

		private float _currentTickInterval;

		private float _radius;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void TickDamage()
		{
		}
	}
}
