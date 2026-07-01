using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaWaveSystem : IRoundEventProvider
	{
		private readonly ArenaConfig _config;

		public int CurrentRound { get; private set; }

		public int MaxRounds => 0;

		public bool IsMaxRoundReached => false;

		public event Action OnRoundAdvanced
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

		event Action IRoundEventProvider.OnRoundStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public ArenaWaveSystem(ArenaConfig config)
		{
		}

		public int GetCardsCount()
		{
			return 0;
		}

		public void AdvanceRound()
		{
		}
	}
}
