using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ScaleByRadius : AbilityObjectComponent
	{
		[SerializeField]
		private Transform _scaleTarget;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private float GetColliderRadius(GameObject target)
		{
			return 0f;
		}
	}
}
