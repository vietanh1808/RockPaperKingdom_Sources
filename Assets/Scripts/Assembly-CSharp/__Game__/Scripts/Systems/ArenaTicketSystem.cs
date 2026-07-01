using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Gameplay.Arena;

namespace __Game__.Scripts.Systems
{
	public class ArenaTicketSystem : ITickable
	{
		private const int RECOVER_AMOUNT = 1;

		private const float UPDATE_RATE = 1f;

		private readonly ArenaConfig _arenaConfig;

		private TimeSpan _fullRecoverTime;

		private float _updateTimer;

		public DateTime LastRecoverTime { get; set; }

		public TimeSpan TimeToRecover { get; private set; }

		public int TicketAmount { get; private set; }

		public int MaxTickets => 0;

		public bool IsMaxTickets => false;

		public bool HasTickets => false;

		public event Action<int> OnAmountChanged
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

		public event Action OnTimeChanged
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

		public ArenaTicketSystem(ArenaConfig arenaConfig)
		{
		}

		public void Initialize()
		{
		}

		public void Tick()
		{
		}

		public void SetAmount(int amount)
		{
		}

		public void AddAmount(int amount)
		{
		}

		public void SpendTicket()
		{
		}

		private void TickTimer()
		{
		}

		private void UpdateTickets()
		{
		}

		private void UpdateTimeToRecover()
		{
		}

		private bool IsRecoverTimeLoaded()
		{
			return false;
		}
	}
}
