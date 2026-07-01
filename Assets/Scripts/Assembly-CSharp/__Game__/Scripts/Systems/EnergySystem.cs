using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class EnergySystem : ITickable
	{
		private const int RECOVER_AMOUNT = 1;

		private const float UPDATE_RATE = 1f;

		private readonly StageSystem _stageSystem;

		private readonly InventorySystem _inventorySystem;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private TimeSpan _fullRecoverTime;

		private int _recoverMinutes;

		private float _updateTimer;

		public DateTime LastRecoverTime { get; set; }

		public TimeSpan TimeToRecover { get; private set; }

		public int EnergyAmount { get; private set; }

		public EnergyConfig EnergyConfig { get; }

		public int MaxAmount => 0;

		public bool IsMaxEnergy => false;

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

		public event Action<int> OnMaxAmountChanged
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

		public EnergySystem(EnergyConfig energyConfig, StageSystem stageSystem, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
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

		public void ApplyCapacityExtension(int bonus)
		{
		}

		public void SpendBySession()
		{
		}

		public void SpendAmount(int amount, string transactionName, string placement)
		{
		}

		private void TickTimer()
		{
		}

		private void UpdateEnergy()
		{
		}

		private void UpdateRecoverMinutes()
		{
		}

		private void UpdateTimeToRecover()
		{
		}

		private bool IsRecoverTimeLoaded()
		{
			return false;
		}

		private void TrackEnergyReceived(int amount)
		{
		}

		private int GetCapacityBonus()
		{
			return 0;
		}
	}
}
