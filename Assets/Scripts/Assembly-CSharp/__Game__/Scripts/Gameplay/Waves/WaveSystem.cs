using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Boss;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSystem : MonoBehaviour, IRoundEventProvider
	{
		private StageSystem _stageSystem;

		private SlotGridUnitSpawnerEnemy _slotGridUnitSpawnerEnemy;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private BossFightController _bossFightController;

		private WaveSpawnPatterns _waveSpawnPatterns;

		private WaveDifficulty[] _waveDifficulties;

		private bool _isWaveRunning;

		private bool _useOverrideStatsMultiplier;

		private StatsMultiplierData _overrideStatsMultiplierData;

		private WaveState _waveState;

		public WaveState WaveState
		{
			get
			{
				return default(WaveState);
			}
			private set
			{
			}
		}

		public int WavesAmount { get; private set; }

		public int WaveIndex { get; private set; }

		public float WaveRuntimeDuration { get; private set; }

		public float TotalRuntimeDuration { get; private set; }

		public float TotalCompletionRate { get; private set; }

		public bool IsLastWaveFinished { get; private set; }

		public bool IsBossWave { get; private set; }

		public StatsMultiplierData StatsMultiplierData { get; private set; }

		public event Action OnInitialized
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

		public event Action OnWaveStarted
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

		public event Action OnWaveStateChanged
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

		public event Action OnWaveCompleted
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

		public event Action OnLastWaveFinished
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

		public event Action OnWaveTimeUpdate
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

		event Action IRoundEventProvider.OnRoundStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		[Inject]
		private void Inject(StageSystem stageSystem, SlotGridUnitSpawnerEnemy slotGridUnitSpawnerEnemy, UIGameplaySceneNavigation uiGameplaySceneNavigation, BossFightController bossFightController)
		{
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void RestoreProgress(float runtimeTimePlay, int waveIndex)
		{
		}

		public void StartWave()
		{
		}

		public void CompleteCurrentWave()
		{
		}

		public void RestartCurrentWave()
		{
		}

		public void OverrideCompletionRate(float completionRate)
		{
		}

		public void OverrideWaveIndex(int waveIndex)
		{
		}

		public void OverrideStatsMultiplierData(StatsMultiplierData data)
		{
		}

		public WaveDifficulty GetWaveDifficulty(int waveIndex)
		{
			return default(WaveDifficulty);
		}

		public WaveSpawnPatterns GetWaveSpawnPatterns()
		{
			return null;
		}

		private void Update()
		{
		}

		private void UpdateMissionProgress()
		{
		}

		private void SpawnEnemyUnits()
		{
		}

		private void InitializeWaveDifficulties()
		{
		}

		private WaveDifficulty ResolveWaveDifficulty(int waveIndex)
		{
			return default(WaveDifficulty);
		}

		private void UpdateStatsMultiplierData()
		{
		}
	}
}
