using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ReleaseByTime : AbilityObjectComponent
	{
		[SerializeField]
		private float _timeToRelease;

		private AbilityObject _effectAbilityObject;

		private float _releaseDuration;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}
	}
}
