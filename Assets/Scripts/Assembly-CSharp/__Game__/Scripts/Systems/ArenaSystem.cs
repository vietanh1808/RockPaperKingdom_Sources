using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Arena;

namespace __Game__.Scripts.Systems
{
	public class ArenaSystem : IFeatureUnlockSystem
	{
		private readonly ArenaConfig _arenaConfig;

		private int _entryPenalty;

		public bool IsFeatureUnlocked { get; private set; }

		public int Rating { get; private set; }

		public int FightCount { get; private set; }

		public ArenaTierData CurrentTier => null;

		public int CurrentTierIndex => 0;

		public event Action OnRatingChanged
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

		public event Action OnMatchStarted
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

		public event Action<ArenaMatchResult, ArenaMatchOutcome> OnMatchFinished
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

		public ArenaSystem(ArenaConfig arenaConfig)
		{
		}

		public void UnlockFeature(bool isFirstUnlock)
		{
		}

		public void LoadData(int rating, int fightCount)
		{
		}

		public void SetRating(int rating)
		{
		}

		public void SetFightCount(int fightCount)
		{
		}

		public void ApplyMatchEntry()
		{
		}

		public ArenaMatchResult ApplyMatchResult(ArenaMatchOutcome outcome)
		{
			return default(ArenaMatchResult);
		}
	}
}
