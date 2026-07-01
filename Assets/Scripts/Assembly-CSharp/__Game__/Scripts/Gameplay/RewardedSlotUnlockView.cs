using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class RewardedSlotUnlockView : MonoBehaviour
	{
		[SerializeField]
		private GameObject _content;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		private string _placementName;

		[SerializeField]
		private SoundData _rewardedSfx;

		private GameplayStateMachine _stateMachine;

		private BuildingSlotGrid _buildingSlotGrid;

		private BuildingPlacementHand _buildingPlacementHand;

		private GridExpandSystem _gridExpandSystem;

		private GameplayInventorySystem _inventorySystem;

		private IAdsService _adsService;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Dictionary<Vector2Int, Transform> _slotViewTransforms;

		private Vector2Int _chosenPosition;

		private bool _isShowing;

		private bool _isInPlacementState;

		private bool _evaluatePending;

		[Inject]
		public void Inject(GameplayStateMachine stateMachine, BuildingSlotGrid buildingSlotGrid, BuildingPlacementHand buildingPlacementHand, GridExpandSystem gridExpandSystem, GameplayInventorySystem inventorySystem, IAdsService adsService, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnStateEntered(BaseGameplayState state)
		{
		}

		private void OnHasEmptySlotsChanged(bool hasEmptySlots)
		{
		}

		private void OnExpandModeChanged()
		{
		}

		private void OnItemAmountChanged(InventoryItem item)
		{
		}

		private void OnRewardedStatusChanged()
		{
		}

		private void OnBuildingRemoved(BuildingUpgradeRuntime removedUpgrade)
		{
		}

		private void ScheduleEvaluate()
		{
		}

		private void OnMouseDown()
		{
		}

		private void EvaluateVisibility()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void RequestRewardedAd()
		{
		}

		private void OnRewardedCompleted(bool success)
		{
		}

		private bool HasUnplaceableCard()
		{
			return false;
		}

		private List<Vector2Int> GetExpandableLocked()
		{
			return null;
		}

		private void CacheSlotViewTransforms()
		{
		}
	}
}
