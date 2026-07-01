using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class BurningGroundAura : AbilityObjectComponent
	{
		private AbilityObject _abilityObject;

		private Transform _followTransform;

		private StatValue _radiusStat;

		private StatValue _tickInterval;

		private float _tickCooldown;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void OnAbilityDeactivated()
		{
		}
	}
}
