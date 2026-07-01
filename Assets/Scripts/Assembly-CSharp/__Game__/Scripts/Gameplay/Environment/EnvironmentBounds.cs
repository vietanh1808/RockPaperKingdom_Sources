using UnityEngine;

namespace __Game__.Scripts.Gameplay.Environment
{
	public class EnvironmentBounds : MonoBehaviour
	{
		[SerializeField]
		private Bounds _bounds;

		public bool IsInsideBounds(Vector3 position)
		{
			return false;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
