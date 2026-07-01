using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	public class SpeedUpGameplaySystem
	{
		private readonly GameplayDebugSettings _gameplayDebugSettings;

		private readonly SpeedUpConfig _speedUpConfig;

		private readonly SpeedUpPurchaseSystem _speedUpPurchaseSystem;

		public bool IsSpeedUpEnabled { get; private set; }

		public event Action OnEnableStatusChanged
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

		public SpeedUpGameplaySystem(GameplayDebugSettings gameplayDebugSettings, SpeedUpConfig speedUpConfig, SpeedUpPurchaseSystem speedUpPurchaseSystem)
		{
		}

		public void Initialize()
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		private float GetCurrentTimeScale()
		{
			return 0f;
		}
	}
}
