using System;
using UnityEngine;
using __Game__.Scripts.Gameplay.StateMachine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingPlacementSimulator : IDisposable
	{
		private readonly BuildingPlacementSystem _buildingPlacementSystem;

		private readonly GridExpandSystem _gridExpandSystem;

		private readonly GameplayStateMachine _gameplayStateMachine;

		private readonly RockPaperScissorsSimulator _rpsSimulator;

		private readonly BuildingSlotGrid _slotGrid;

		private readonly BuildingPlacementHand _placementHand;

		private readonly BuildingPlacementConfig _config;

		public BuildingPlacementSimulator(BuildingPlacementSystem buildingPlacementSystem, GridExpandSystem gridExpandSystem, GameplayStateMachine gameplayStateMachine, RockPaperScissorsSimulator rpsSimulator, BuildingPlacementConfig config)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnStateEntered(BaseGameplayState state)
		{
		}

		private void ProcessPendingPlacements()
		{
		}

		private void RetryRemainingHandCards()
		{
		}

		private void TryPlaceBuilding(BuildingUpgradeRuntime upgrade)
		{
		}

		private bool TryExpandGridSlot()
		{
			return false;
		}

		private void ExecutePlacement(Vector2Int position)
		{
		}
	}
}
