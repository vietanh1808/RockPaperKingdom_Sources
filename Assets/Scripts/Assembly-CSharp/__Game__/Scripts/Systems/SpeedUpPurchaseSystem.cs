using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class SpeedUpPurchaseSystem
	{
		private const string COOLDOWN_GUID = "GameplaySpeedUpCooldown";

		private readonly CooldownSystem _cooldownSystem;

		private readonly SpeedUpConfig _speedUpConfig;

		private readonly IAdsService _adsService;

		private bool _isPurchaseInProgress;

		private bool _isSpeedUpAvailable;

		public bool IsSpeedUpAvailable
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public CooldownListener Cooldown { get; }

		public event Action OnAvailableStatusChanged
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

		public SpeedUpPurchaseSystem(CooldownSystem cooldownSystem, SpeedUpConfig speedUpConfig, IAdsService adsService)
		{
		}

		public void Initialize()
		{
		}

		public void Purchase()
		{
		}

		private void OnVideoRewarded(bool isSuccessful)
		{
		}

		private void OnCooldownStatusChanged(bool isCooldown)
		{
		}
	}
}
