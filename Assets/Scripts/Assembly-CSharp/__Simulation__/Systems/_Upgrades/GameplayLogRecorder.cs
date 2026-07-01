using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems._Upgrades
{
	public class GameplayLogRecorder : IInitializable, IDisposable
	{
		private readonly WaveSystem _waveSystem;

		private readonly StageSystem _stageSystem;

		private readonly Castle _castle;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly UnitHealthPercentTracker _unitHealthPercentTracker;

		private readonly UnitPowerTracker _unitPowerTracker;

		private int _currentWaveIndex;

		private int _playerUnitsPowerAtWaveStart;

		private bool _forceSkipPending;

		public StageLog StageLog { get; }

		public event Action OnLogRecorded
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

		public GameplayLogRecorder(WaveSystem waveSystem, StageSystem stageSystem, Castle castle, GameplayUpgradesSystem gameplayUpgradesSystem, UnitHealthPercentTracker unitHealthPercentTracker, UnitPowerTracker unitPowerTracker)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void MarkNextWaveAsForceSkipped()
		{
		}

		public void RecordFinalWaveLog()
		{
		}

		private void OnWaveStarted()
		{
		}

		private void OnWaveStateChanged()
		{
		}

		private void OnStageFinished(float completionRate)
		{
		}

		private void AddWaveLog()
		{
		}

		private void AddFinalWaveLog()
		{
		}

		private void RecordWaveLog()
		{
		}
	}
}
