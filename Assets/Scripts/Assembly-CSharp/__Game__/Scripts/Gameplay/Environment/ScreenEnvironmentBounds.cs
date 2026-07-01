using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay.Environment
{
	public class ScreenEnvironmentBounds : ITickable
	{
		private Camera _camera;

		private Vector3 _lastCameraPosition;

		private Bounds _bounds;

		public Bounds Bounds => default(Bounds);

		[Inject]
		private void Inject(Camera camera)
		{
		}

		public void Tick()
		{
		}

		public bool IsInsideBounds(Vector3 position)
		{
			return false;
		}

		private void CalculateWorldBounds()
		{
		}

		public Vector3 GetRandomPosition()
		{
			return default(Vector3);
		}
	}
}
