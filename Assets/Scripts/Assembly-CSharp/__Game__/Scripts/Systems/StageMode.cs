using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class StageMode
	{
		public int SelectedStageIndex;

		public int MaxAvailableIndex;

		public int LastAvailableIndex;

		public Dictionary<int, StageAttemptData> AttemptDataPerStage;

		public Dictionary<int, float> BestRemainingHPPerStage;

		public Dictionary<int, float> BestCompletionRatePerStage;
	}
}
