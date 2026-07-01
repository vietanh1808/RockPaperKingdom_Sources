using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.EnemyHint
{
	public class EnemyHintSystem
	{
		private readonly EnemyHintConfig _config;

		private readonly WaveSystem _waveSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly EnemyHintRuntimeData _runtimeData;

		public EnemyHintSystem(EnemyHintConfig config, WaveSystem waveSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, EnemyHintRuntimeData runtimeData)
		{
		}

		private void OnWaveStarted()
		{
		}
	}
}
