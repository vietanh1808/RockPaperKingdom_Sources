using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayLevelSystem
	{
		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly List<int> _experienceRequiredPerLevel;

		public int CurrentExperience { get; private set; }

		public int NextLevelExperience { get; private set; }

		public int LevelIndex { get; private set; }

		public float LevelProgression => 0f;

		private bool HasNextLevel => false;

		public event Action OnExperienceUpdated
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

		public event Action OnLevelIncreased
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

		public event Action OnLevelRestored
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

		public GameplayLevelSystem(StageSystem stageSystem, WaveSystem waveSystem)
		{
		}

		public void Initialize()
		{
		}

		public void RestoreProgress(int levelIndex, int currentLevelExperience)
		{
		}

		public void AddExperience(int experience)
		{
		}

		private void LevelUp()
		{
		}

		private void UpdateNextLevelExperience()
		{
		}
	}
}
