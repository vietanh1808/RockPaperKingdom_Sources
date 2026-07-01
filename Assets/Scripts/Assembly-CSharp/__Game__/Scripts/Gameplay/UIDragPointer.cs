using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIDragPointer : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _canvasTransform;

		[SerializeField]
		private RectTransform _lineTransform;

		[SerializeField]
		private RectTransform _startPointerTransform;

		[SerializeField]
		private RectTransform _endPointerTransform;

		[SerializeField]
		private RectTransform _directionPointerTransform;

		[Header("Animation Settings")]
		[SerializeField]
		private float _directionPointerSpeed;

		[SerializeField]
		private float _displayDelay;

		private Camera _mainCamera;

		private RectTransform _startRectTransform;

		private Transform _endWorldTransform;

		private Vector2 _previousStartAnchoredPosition;

		private Vector2 _startAnchoredPosition;

		private Vector2 _endAnchoredPosition;

		private float _angle;

		private float _elapsedDisplayTime;

		private bool _areVisualsVisible;

		[Inject]
		private void Inject(Camera mainCamera)
		{
		}

		private void Update()
		{
		}

		public void StartTracking(RectTransform fromRectTransform, Transform toWorldTransform)
		{
		}

		public void StopTracking()
		{
		}

		private void UpdatePositions()
		{
		}

		private void UpdateLine()
		{
		}

		private void UpdatePointers()
		{
		}

		private void UpdateHand()
		{
		}

		private Vector2 GetAnchoredPositionFromScreen(Vector2 screenPoint)
		{
			return default(Vector2);
		}
	}
}
