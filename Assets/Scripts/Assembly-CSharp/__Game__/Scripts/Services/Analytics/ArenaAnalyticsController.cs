using System;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services.Analytics
{
	public class ArenaAnalyticsController : IDisposable
	{
		private readonly GameAnalyticsEvents _gameAnalyticsEvents;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly ArenaWaveSystem _arenaWaveSystem;

		private readonly ArenaSystem _arenaSystem;

		[Inject]
		public ArenaAnalyticsController(GameAnalyticsEvents gameAnalyticsEvents, GameplayUpgradesSystem gameplayUpgradesSystem, ArenaWaveSystem arenaWaveSystem, ArenaSystem arenaSystem)
		{
		}

		public void Dispose()
		{
		}

		private void OnUpgradeApplied(BaseGameplayUpgrade upgrade, UpgradeSource source)
		{
		}
	}
}
