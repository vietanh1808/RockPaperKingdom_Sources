using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class SlotGridSpawnPoint : MonoBehaviour
	{
		[SerializeField]
		private Vector2Int _gridPosition;

		public Vector2Int GridPosition => default(Vector2Int);

		public Vector3 WorldPosition => default(Vector3);
	}
}
