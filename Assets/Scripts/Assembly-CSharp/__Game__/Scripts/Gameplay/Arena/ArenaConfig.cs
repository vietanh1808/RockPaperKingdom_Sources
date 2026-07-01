using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay.StakeToken;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	[CreateAssetMenu(fileName = "Config_Arena", menuName = "TapHub/Arena/Arena Config")]
	public class ArenaConfig : ScriptableObject
	{
		private const int DEFAULT_CARDS_PER_ROUND = 1;

		[Header("Rating")]
		[SerializeField]
		private List<ArenaTierData> _tiers;

		[Header("Round Settings")]
		[SerializeField]
		private int _maxRounds;

		[SerializeField]
		private List<int> _cardsPerRound;

		[Header("First Fight Strategies")]
		[SerializeField]
		private List<ArenaEnemyStrategyData> _firstFightStrategies;

		[Header("Tickets")]
		[SerializeField]
		private int _maxTickets;

		[SerializeField]
		private int _ticketRecoverMinutes;

		[SerializeField]
		private ArenaTicketItemData _ticketItemData;

		[Header("Stake Token")]
		[SerializeField]
		private StakeTokenSettings _stakeTokenSettings;

		public int MaxRounds => 0;

		public List<ArenaTierData> Tiers => null;

		public List<ArenaEnemyStrategyData> FirstFightStrategies => null;

		public int MaxTickets => 0;

		public int TicketRecoverMinutes => 0;

		public ArenaTicketItemData TicketItemData => null;

		public StakeTokenSettings StakeTokenSettings => null;

		public ArenaTierData GetTierForRating(int rating)
		{
			return null;
		}

		public int GetTierIndexForRating(int rating)
		{
			return 0;
		}

		public ArenaTierData GetNextTierForRating(int rating)
		{
			return null;
		}

		public int GetCardsForRound(int roundIndex)
		{
			return 0;
		}
	}
}
