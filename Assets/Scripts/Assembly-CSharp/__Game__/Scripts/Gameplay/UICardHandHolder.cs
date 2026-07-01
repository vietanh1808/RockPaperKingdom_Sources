using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UICardHandHolder : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private RectTransform _spawnContainer;

		[SerializeField]
		private RectTransform _spawnPoint;

		[SerializeField]
		private UICardHandItem _uiCardHandItemPrefab;

		[Header("Hand Settings")]
		[SerializeField]
		private float _handWidth;

		[SerializeField]
		private float _cardWidth;

		[SerializeField]
		private float _cardHeight;

		[SerializeField]
		private float _cardSpacing;

		[Header("Fan Effect")]
		[SerializeField]
		private float _maxRotationAngle;

		[SerializeField]
		private float _verticalCurve;

		[Header("Animation")]
		[SerializeField]
		private float _repositionDuration;

		[SerializeField]
		private AnimationCurve _repositionCurve;

		private readonly List<UICardHandItem> _cardItems;

		private readonly Dictionary<BuildingUpgradeRuntime, UICardHandItem> _cardItemByUpgrade;

		private readonly Dictionary<UICardHandItem, Tween> _cardTweens;

		private BuildingPlacementHand _buildingPlacementHand;

		private UICardHandItem _selectedCard;

		public bool IsDragging { get; private set; }

		public event Action OnCardAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCardRemoved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCardSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCardDragging
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(BuildingPlacementHand buildingPlacementHand)
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void OverrideSettings(float cardWidthMultiplier, float cardHeightMultiplier)
		{
		}

		private void OnEnable()
		{
		}

		private void SpawnCardsForPendingBuildings()
		{
		}

		private void OnDisable()
		{
		}

		private void ClearAllCards()
		{
		}

		public void SetCardSelected(UICardHandItem uiCardHandItem)
		{
		}

		public void SetCardDeselected(UICardHandItem uiCardHandItem)
		{
		}

		public void SetCardDragged(bool isDragging)
		{
		}

		public List<UICardHandItem> GetCardItems()
		{
			return null;
		}

		private void OnBuildingAdded(BuildingUpgradeRuntime upgrade)
		{
		}

		private void CreateCardForBuilding(BuildingUpgradeRuntime upgrade)
		{
		}

		private void OnBuildingRemoved(BuildingUpgradeRuntime upgrade)
		{
		}

		private void UpdateCardPositions()
		{
		}

		private void DoAnchoredPosition(UICardHandItem card, Vector2 targetPosition, float rotation)
		{
		}

		private void KillCardTween(UICardHandItem card)
		{
		}

		private float GetCardSpacing(int cardCount)
		{
			return 0f;
		}

		private float GetTotalWidth(int cardCount, float spacing)
		{
			return 0f;
		}

		private float GetNormalizedDistance(float horizontalPosition)
		{
			return 0f;
		}

		private float GetCardRotation(float horizontalPosition, float normalizedDistance, float handFillRatio)
		{
			return 0f;
		}

		private Vector2 GetCardPosition(float horizontalPosition, float normalizedDistance, float handFillRatio)
		{
			return default(Vector2);
		}

		private UICardHandItem GetCardTransform(int cardIndex)
		{
			return null;
		}
	}
}
