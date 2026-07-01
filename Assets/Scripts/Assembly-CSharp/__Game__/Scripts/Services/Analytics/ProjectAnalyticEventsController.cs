using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services.Analytics
{
	public class ProjectAnalyticEventsController
	{
		private readonly StageSystem _stageSystem;

		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly ArenaSystem _arenaSystem;

		private readonly GameAnalyticsEvents _gameAnalyticsEvents;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private bool _isAbandoned;

		public ProjectAnalyticEventsController(GameAnalyticsEvents gameAnalyticsEvents, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem, ArenaSystem arenaSystem)
		{
		}

		private void SubscribeToEvents()
		{
		}

		private void OnStageStarted()
		{
		}

		private void OnStageAbandoned(float completionRate)
		{
		}

		private void OnStageFinished(float completionRate)
		{
		}

		private void OnHeroUnlocked(HeroItem heroItem)
		{
		}

		private void OnHeroLevelChanged(HeroItem heroItem)
		{
		}

		private void OnUnitCardUnlocked(UnitCardItem unitCardItem)
		{
		}

		private void OnUnitCardLevelChanged(UnitCardItem unitCardItem)
		{
		}

		private void OnArenaMatchStarted()
		{
		}

		private void OnArenaMatchFinished(ArenaMatchResult matchResult, ArenaMatchOutcome outcome)
		{
		}
	}
}
