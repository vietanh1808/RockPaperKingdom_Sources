using UnityEngine;

namespace __Game__.Scripts.Gameplay.Arena.Enemy
{
	public class EnemyBuildingSlotView : MonoBehaviour
	{
		[SerializeField]
		private Vector2Int _position;

		[SerializeField]
		private GameObject _slotVisuals;

		private BuildingSlot _slot;

		public Vector2Int Position => default(Vector2Int);

		public void Initialize(BuildingSlot slot)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBuildingPlaced(BaseBuilding building)
		{
		}

		private void OnSlotStateChanged()
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
