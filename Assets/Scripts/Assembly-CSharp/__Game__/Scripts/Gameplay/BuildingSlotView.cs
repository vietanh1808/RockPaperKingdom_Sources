using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingSlotView : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private GameObject _slotVisuals;

		[SerializeField]
		private GameObject _expandIndicator;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private SpriteRenderer _groundSprite;

		[SerializeField]
		private GameObject _highlightContainer;

		[SerializeField]
		private SpriteRenderer[] _highlightSprites;

		[SerializeField]
		private Collider _collider;

		[Header("Settings")]
		[SerializeField]
		private Vector2Int _position;

		[Header("Line Renderer Colors")]
		[SerializeField]
		private Color _placementAvailableColor;

		[SerializeField]
		private Color _upgradeAvailableColor;

		private BuildingPlacementSystem _buildingPlacementSystem;

		private BuildingSlotGrid _buildingSlotGrid;

		private BuildingPlacementStateTracker _stateTracker;

		private GridExpandSystem _gridExpandSystem;

		public BuildingSlot BuildingSlot { get; private set; }

		[Inject]
		public void Inject(BuildingPlacementSystem buildingPlacementSystem, BuildingSlotGrid buildingSlotGrid, BuildingPlacementStateTracker stateTracker, GridExpandSystem gridExpandSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void EnterSlot()
		{
		}

		public void ExitSlot()
		{
		}

		public void ConfirmSlot()
		{
		}

		private void OnSlotStateChanged()
		{
		}

		private void OnBuildingPlaced(BaseBuilding building)
		{
		}

		private void OnBuildingDestroyed(BaseBuilding building)
		{
		}

		private void OnHandStateChanged()
		{
		}

		private void ConfirmUpgradeAvailable()
		{
		}

		private bool IsDestroyExpandSelected()
		{
			return false;
		}

		private Color GetLockedExpandColor()
		{
			return default(Color);
		}

		private Color GetUpgradeAvailableColor()
		{
			return default(Color);
		}

		private void SetLineRendererColor(Color color)
		{
		}
	}
}
