using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class FirstEnemyTargetProvider : ITargetProvider
	{
		private static readonly Vector3 DEFAULT_TARGET_POSITION;

		public AbilityTargetLocation GetTargetPosition(Ability ability)
		{
			return null;
		}

		public bool HasTarget(Ability ability)
		{
			return false;
		}
	}
}
