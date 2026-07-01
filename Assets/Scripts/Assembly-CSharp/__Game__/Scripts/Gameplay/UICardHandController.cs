using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace __Game__.Scripts.Gameplay
{
	public class UICardHandController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private UICardHandItem _uiCardHandItem;

		[SerializeField]
		private LayerMask _raycastLayerMask;

		private Camera _mainCamera;

		private BuildingSlotView _currentBuildingSlotView;

		private BuildingSlotView _previousBuildingSlotView;

		private Vector2 _mouseDownPosition;

		private bool _isMouseDown;

		private bool _isMouseDragging;

		private int _trackedTouchId;

		private readonly List<RaycastResult> _raycastResults;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		private void Update()
		{
		}

		private void UpdateMouseDown(bool isMouseDown)
		{
		}

		private void UpdateMouseDragging(bool isMouseDown)
		{
		}

		private void UpdateMouseUp(bool isMouseDown)
		{
		}

		private void OnSlotEnterHandler(BuildingSlotView buildingSlotView)
		{
		}

		private void OnSlotExitHandler()
		{
		}

		private void OnMouseDownHandler()
		{
		}

		private bool ShouldIgnoreDeselect(Vector2 inputPosition)
		{
			return false;
		}

		private void OnMouseDragHandler()
		{
		}

		private void OnMouseUpHandler()
		{
		}

		private Vector2 GetInputPosition()
		{
			return default(Vector2);
		}

		private bool IsInputDown()
		{
			return false;
		}
	}
}
