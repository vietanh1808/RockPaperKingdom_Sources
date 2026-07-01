using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Loading
{
	public class LoadingState : BaseGameState
	{
		private readonly UIFadeDisplay _uiFadeDisplay;

		private readonly GameAnalyticsService _gameAnalyticsService;

		private readonly LoadingProgressController _progressController;

		private readonly StageSystem _stageSystem;

		private readonly RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private readonly TutorialsGameplayRuntimeData _tutorialsGameplayRuntimeData;

		private bool _analyticsInitialized;

		private bool _loadingProgressCompleted;

		public LoadingState(GameAnalyticsService gameAnalyticsService, LoadingProgressController progressController, StageSystem stageSystem, RestoreGameplayRuntimeData restoreGameplayRuntimeData, TutorialsGameplayRuntimeData tutorialsGameplayRuntimeData)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnProgressCompleted()
		{
		}

		private void OnAnalyticsInitialized()
		{
		}

		private void TryProceed()
		{
		}
	}
}
