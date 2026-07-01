using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayRewardSystem
	{
		private readonly RewardSystem _rewardSystem;

		private readonly RewardStorage _rewardStorage;

		public List<Reward> FinalRewards { get; private set; }

		public GameplayRewardSystem(RewardSystem rewardSystem)
		{
		}

		public void AddReward(List<Reward> reward)
		{
		}

		public void AddReward(Reward reward)
		{
		}

		public void ClaimRewards()
		{
		}

		public void ClaimDoubleRewards()
		{
		}
	}
}
