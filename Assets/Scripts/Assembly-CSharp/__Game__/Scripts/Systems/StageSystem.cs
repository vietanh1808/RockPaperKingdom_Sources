using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class StageSystem
	{
		private readonly StagesCollection _stagesCollection;

		private readonly Dictionary<StageModeType, StageMode> _modeData;

		private StageData _overrideStageData;

		public StageModeType CurrentModeType { get; private set; }

		public int SelectedStageIndex => 0;

		public int MaxAvailableIndex => 0;

		public int LastAvailableIndex => 0;

		public Dictionary<int, StageAttemptData> AttemptDataPerStage => null;

		public int AttemptIndex => 0;

		public float MissionProgress { get; set; }

		public float ResultRemainingHP { get; private set; }

		public float BestRemainingHP { get; private set; }

		public bool IsNewBestHP { get; private set; }

		public bool WasLastStageVictory { get; private set; }

		public Dictionary<int, float> BestRemainingHPPerStage => null;

		public Dictionary<int, float> BestCompletionRatePerStage => null;

		private StageMode ActiveData => null;

		public event Action OnStageStarted
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

		public event Action<float> OnStageFinished
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

		public event Action<float> OnStageAbandoned
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

		public event Action OnSelectedIndexChanged
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

		public event Action OnLastAvailableIndexChanged
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

		public event Action OnModeChanged
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

		public StageSystem(StagesCollection stagesCollection)
		{
		}

		public void LoadData(int lastAvailableIndex, Dictionary<int, StageAttemptData> attemptDataPerStage, Dictionary<int, float> bestRemainingHPPerStage, Dictionary<int, float> bestCompletionRatePerStage, int hardLastAvailableIndex, Dictionary<int, StageAttemptData> hardAttemptDataPerStage, Dictionary<int, float> hardBestRemainingHPPerStage, Dictionary<int, float> hardBestCompletionRatePerStage)
		{
		}

		public void Initialize()
		{
		}

		public void SetMode(StageModeType modeType)
		{
		}

		public StageMode GetModeData(StageModeType modeType)
		{
			return null;
		}

		public void OverrideMaxAvailableIndex(int maxAvailableIndex)
		{
		}

		public void OverrideStageData(StageData stageData)
		{
		}

		public void StageStarted()
		{
		}

		public void StageAbandoned(float completionRate)
		{
		}

		public void SetAvailableStageIndex(int value)
		{
		}

		public void SetAvailableStageIndex(StageModeType modeType, int value)
		{
		}

		public void SetSelectedStageIndex(int value)
		{
		}

		public void StageFinished(float completionRate, float remainingHPPercent)
		{
		}

		public StageData GetSelectedStageData()
		{
			return null;
		}

		private void LoadModeData(StageModeType modeType, int lastAvailableIndex, Dictionary<int, StageAttemptData> attemptDataPerStage, Dictionary<int, float> bestRemainingHPPerStage, Dictionary<int, float> bestCompletionRatePerStage)
		{
		}

		private void InitializeModeData(StageModeType modeType)
		{
		}

		private void CheckResultRemainingHP(float remainingHPPercent)
		{
		}

		private void CheckResultCompletionRate(float completionRate)
		{
		}

		private void IncrementAttempt()
		{
		}

		private void AdvanceToNextStage()
		{
		}

		private StageAttemptData GetOrCreateAttemptData(int stageIndex)
		{
			return null;
		}
	}
}
