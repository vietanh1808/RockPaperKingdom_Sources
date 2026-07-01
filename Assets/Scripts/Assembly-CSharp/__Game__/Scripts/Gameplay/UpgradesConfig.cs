using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_Upgrades", menuName = "TapHub/Gameplay/Upgrades Config")]
	public class UpgradesConfig : ScriptableObject
	{
		[Header("Building Settings")]
		[SerializeField]
		private int _maxBuildingLevelIndex;

		[Header("Default Upgrades")]
		[SerializeField]
		private RewardUpgrade[] _rewards;

		public int MaxBuildingLevelIndex => 0;

		public RewardUpgrade[] Rewards => null;
	}
}
