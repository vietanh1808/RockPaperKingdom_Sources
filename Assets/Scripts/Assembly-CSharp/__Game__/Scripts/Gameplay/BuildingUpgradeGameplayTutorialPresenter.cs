using Zenject;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingUpgradeGameplayTutorialPresenter : BaseGameplayTutorialPresenter
	{
		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private StageSystem _stageSystem;

		private WaveSystem _waveSystem;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, StageSystem stageSystem, WaveSystem waveSystem)
		{
		}

		public override void Initialize()
		{
		}

		private void OnUpgradesSpawned()
		{
		}
	}
}
