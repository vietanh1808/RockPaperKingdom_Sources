using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public static class InputRaycastService
	{
		private static readonly Vector3 WORLD_OFFSET;

		public static bool Raycast(Camera camera, LayerMask layerMask, out RaycastHit hit)
		{
			hit = default(RaycastHit);
			return false;
		}

		public static Ray GetInputRay(Camera camera)
		{
			return default(Ray);
		}

		public static Vector2 GetInputPosition()
		{
			return default(Vector2);
		}
	}
}
