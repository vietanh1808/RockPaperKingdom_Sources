using __Game__.Scripts.Gameplay.Arena.UI;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaBuildingPlacementState : BaseArenaState
	{
		private readonly UIArenaSceneNavigation _uiArenaSceneNavigation;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingPlacementHand _buildingPlacementHand;

		private readonly CardSellSystem _cardSellSystem;

		private bool _isTransitionBlocked;

		public ArenaBuildingPlacementState(UIArenaSceneNavigation uiArenaSceneNavigation, BuildingRepository buildingRepository, BuildingPlacementHand buildingPlacementHand, CardSellSystem cardSellSystem)
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
	}
}
