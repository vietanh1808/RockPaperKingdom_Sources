using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class StageFeatureUnlockProcessor
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly StageSystem _stageSystem;

		private readonly Dictionary<int, List<FeatureItem>> _featuresPerStage;

		public StageFeatureUnlockProcessor(FeatureUnlockSystem featureUnlockSystem, StageSystem stageSystem)
		{
		}

		private void InitializeStageFeatureUnlock()
		{
		}

		private void AddFeaturePerStage(int stageIndex, FeatureItem featureItem)
		{
		}

		private void OnLastAvailableIndexChanged()
		{
		}

		private bool IsStageCompleted(int stageIndex)
		{
			return false;
		}
	}
}
