using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class RockPaperScissorsSimulator : IDisposable
	{
		private readonly RockPaperScissorsSystem _rpsSystem;

		private readonly GridExpandSystem _gridExpandSystem;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly BuildingSlotGrid _slotGrid;

		private bool _isProcessing;

		public RockPaperScissorsSimulator(RockPaperScissorsSystem rpsSystem, GridExpandSystem gridExpandSystem, GameplayInventorySystem gameplayInventorySystem, BuildingSlotGrid slotGrid)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnItemAmountChanged(InventoryItem item)
		{
		}

		public void ProcessImmediate()
		{
		}

		private void Process()
		{
		}

		private void PlayAllAvailableRPS()
		{
		}

		private void ExpandAllAvailableSlots()
		{
		}

		private List<Vector2Int> GetExpandableSlots()
		{
			return null;
		}

		private RPSChoice GetRandomChoice()
		{
			return default(RPSChoice);
		}
	}
}
