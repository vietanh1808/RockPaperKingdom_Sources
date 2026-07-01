using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class EquipmentUpgradeRefundSystem
	{
		private readonly EquipmentSystem _equipmentSystem;

		private readonly EquipmentConfig _equipmentConfig;

		private readonly RewardSystem _rewardSystem;

		public EquipmentUpgradeRefundSystem(EquipmentSystem equipmentSystem, EquipmentConfig equipmentConfig, RewardSystem rewardSystem)
		{
		}

		public void LevelDownAndClaimRefunds(EquipmentItem item, RewardDisplayMode rewardDisplayMode)
		{
		}

		public List<Reward> GetRefundItems(EquipmentItem item)
		{
			return null;
		}
	}
}
