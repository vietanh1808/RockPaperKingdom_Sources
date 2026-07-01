using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class BuildingPlacementState : BaseGameplayState
	{
		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingPlacementHand _buildingPlacementHand;

		private readonly RestoreGameplayProgressSystem _restoreGameplayProgressSystem;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayConfig _gameplayConfig;

		private readonly CardSellSystem _cardSellSystem;

		private InventoryItem _gameplayCardItem;

		private bool _isTransitionBlocked;

		public BuildingPlacementState(UIGameplaySceneNavigation uiGameplaySceneNavigation, BuildingRepository buildingRepository, BuildingPlacementHand buildingPlacementHand, RestoreGameplayProgressSystem restoreGameplayProgressSystem, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, CardSellSystem cardSellSystem)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnFightButtonClicked()
		{
		}

		private void OnLastCardSelling()
		{
		}

		private void OnBuildingRemoved(BuildingUpgradeRuntime removedUpgrade)
		{
		}

		private void CacheInventoryItems()
		{
		}
	}
}
