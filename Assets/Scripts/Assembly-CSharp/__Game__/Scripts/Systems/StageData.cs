using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Gameplay.StakeToken;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StageData_", menuName = "TapHub/Data/Stage Data")]
	public class StageData : SerializedScriptableObject
	{
		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private WaveLevelProgressionData _waveLevelProgressionData;

		[SerializeField]
		private GameObject _levelDesignPrefab;

		[SerializeField]
		private WaveSpawnPatterns _waveSpawnPatternsPrefab;

		[SerializeField]
		private List<RewardData> _defeatRewardsData;

		[SerializeField]
		private List<RewardData> _victoryRewardsData;

		[SerializeField]
		private List<StageChestData> _stageChests;

		[SerializeField]
		private EnemyStatMultiplierSettings _enemyStatMultiplierSettings;

		[SerializeField]
		private List<StageUpgradeRound> _upgradeRounds;

		[SerializeField]
		private List<StageBossChestUpgradeRound> _bossChestUpgradeRounds;

		[SerializeField]
		private List<int> _mysteryCardShopRewardWaves;

		[SerializeField]
		private StakeTokenSettings _stakeTokenSettings;

		[SerializeField]
		private List<PredefinedRpsPlay> _predefinedRpsPlays;

		public Sprite Icon => null;

		public GameObject LevelDesignPrefab => null;

		public WaveSpawnPatterns WaveSpawnPatternsPrefab => null;

		public List<Reward> VictoryRewards => null;

		public List<Reward> DefeatRewards => null;

		public List<StageChestData> StageChests => null;

		public List<StageUpgradeRound> UpgradeRounds => null;

		public List<StageBossChestUpgradeRound> BossChestUpgradeRounds => null;

		public List<int> MysteryCardShopRewardWaves => null;

		public StakeTokenSettings StakeTokenSettings => null;

		public List<PredefinedRpsPlay> PredefinedRpsPlays => null;

		public int GetWavesCount()
		{
			return 0;
		}

		public List<int> GetLevelUpsPerWave()
		{
			return null;
		}

		public List<int> GetExperienceRequiredPerLevel(WaveSpawnPatterns waveSpawnPatterns)
		{
			return null;
		}

		public float GetStatHealthMultiplier(int waveIndex)
		{
			return 0f;
		}

		public float GetStatDamageMultiplier(int waveIndex)
		{
			return 0f;
		}

		public float GetStatCastleDamageMultiplier()
		{
			return 0f;
		}
	}
}
