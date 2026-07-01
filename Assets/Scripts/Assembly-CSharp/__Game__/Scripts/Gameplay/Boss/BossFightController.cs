using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Boss
{
	public class BossFightController
	{
		private readonly SoundsConfig _soundsConfig;

		private readonly WavesConfig _wavesConfig;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private BaseUnit _currentBossUnit;

		private SoundData _previousSoundData;

		public event Action OnBossDefeated
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

		public BossFightController(SoundsConfig soundsConfig, WavesConfig wavesConfig, UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		public void ShowFight(BaseUnit bossUnit)
		{
		}

		private void OnDiedHandler()
		{
		}
	}
}
