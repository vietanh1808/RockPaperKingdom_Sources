using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityTargetLocation
	{
		private Vector3 _lastKnownPosition;

		private readonly Transform _targetTransform;

		public AbilityTargetLocation(Vector3 position)
		{
		}

		public AbilityTargetLocation(Transform targetTransform)
		{
		}

		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		public Transform GetTransform()
		{
			return null;
		}
	}
}
