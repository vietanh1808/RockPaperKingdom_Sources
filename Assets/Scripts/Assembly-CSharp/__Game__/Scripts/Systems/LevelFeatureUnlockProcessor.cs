using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class LevelFeatureUnlockProcessor
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly Dictionary<int, List<FeatureItem>> _featuresPerLevel;

		private int _currentLevelIndex;

		public LevelFeatureUnlockProcessor(FeatureUnlockSystem featureUnlockSystem, PlayerLevelSystem playerLevelSystem)
		{
		}

		private void InitializeLevelFeatureUnlock()
		{
		}

		private void AddFeaturePerLevel(int level, FeatureItem featureItem)
		{
		}

		private void OnLevelUpCompleted()
		{
		}

		private void AddPendingFeaturesByLevel(int level)
		{
		}
	}
}
