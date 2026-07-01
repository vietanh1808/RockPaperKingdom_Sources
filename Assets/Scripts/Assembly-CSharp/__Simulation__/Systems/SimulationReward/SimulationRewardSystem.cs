using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.SimulationReward
{
	public class SimulationRewardSystem
	{
		private readonly RewardSystem _rewardSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly SimulationSnapshot _simulationSnapshot;

		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		private readonly HeroSystem _heroSystem;

		private readonly HeroConfig _heroConfig;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly UnitCardConfig _unitCardConfig;

		public SimulationRewardSystem(RewardSystem rewardSystem, SimulationSnapshot simulationSnapshot, PlayerLevelSystem playerLevelSystem, FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig, PatrolRewardsSystem patrolRewardsSystem, HeroSystem heroSystem, HeroConfig heroConfig, UnitCardSystem unitCardSystem, UnitCardConfig unitCardConfig)
		{
		}

		public void ClaimReward(string rewardType, List<Reward> rewards)
		{
		}

		public void HandleSimulationReward(string rewardType, List<Reward> rewards)
		{
		}

		private void UnlockPendingHeroes()
		{
		}

		private void ClaimHeroUnlockReward(string guid)
		{
		}

		private void ClaimHeroUnitCardUnlockRewards(string heroGuid)
		{
		}

		private void TryLevelUp()
		{
		}

		private void TryUnlockFeatures()
		{
		}

		private void HandlePatrolUnlock(FeatureItem item)
		{
		}
	}
}
