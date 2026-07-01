using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UICardSellButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonStateView _buttonStateView;

		[SerializeField]
		private RectTransform _dropZone;

		[SerializeField]
		private GameObject _highlightObject;

		[Header("Sell Feedback")]
		[SerializeField]
		private RectTransform _sellFeedbackContainer;

		[SerializeField]
		private CanvasGroup _sellFeedbackCanvasGroup;

		[SerializeField]
		private float _sellFeedbackScaleDuration;

		[SerializeField]
		private float _sellFeedbackFadeDelay;

		[SerializeField]
		private float _sellFeedbackFadeDuration;

		[SerializeField]
		private SoundData _sellSfx;

		private CardSellSystem _cardSellSystem;

		private BuildingPlacementHand _buildingPlacementHand;

		private bool _wasInputDown;

		private bool _isOverDropZone;

		private Sequence _sellFeedbackSequence;

		[Inject]
		public void Inject(CardSellSystem cardSellSystem, BuildingPlacementHand buildingPlacementHand)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void UpdateHighlight(bool isOver)
		{
		}

		private void SetHighlight(bool isHighlighted)
		{
		}

		private void SellActiveCard()
		{
		}

		private void PlaySellFeedback()
		{
		}

		private void OnSelectedBuildingChanged()
		{
		}

		private void UpdateVisibility()
		{
		}

		private bool IsInputDown()
		{
			return false;
		}

		private Vector2 GetInputPosition()
		{
			return default(Vector2);
		}
	}
}
