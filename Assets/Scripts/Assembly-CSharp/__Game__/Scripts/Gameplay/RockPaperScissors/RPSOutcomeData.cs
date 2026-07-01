using System;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	[Serializable]
	public class RPSOutcomeData
	{
		[SerializeField]
		private RPSOutcomeType _outcomeType;

		[SerializeField]
		private InventoryItemData _rewardItem;

		[SerializeField]
		private int _rewardAmount;

		public RPSOutcomeType OutcomeType => default(RPSOutcomeType);

		public InventoryItemData RewardItem => null;

		public int RewardAmount => 0;

		public Sprite OutcomeIcon => null;

		public RPSOutcomeData(RPSOutcomeType outcomeType, InventoryItemData rewardItem, int rewardAmount)
		{
		}
	}
}
