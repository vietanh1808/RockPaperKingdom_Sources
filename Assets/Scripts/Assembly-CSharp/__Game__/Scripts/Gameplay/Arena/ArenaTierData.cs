using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	[CreateAssetMenu(fileName = "ArenaTier_", menuName = "TapHub/Arena/Arena Tier Data")]
	public class ArenaTierData : ScriptableObject
	{
		[SerializeField]
		private int _requiredRating;

		[SerializeField]
		private string _name;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private int _winRating;

		[SerializeField]
		private int _loseRating;

		[Header("Rewards")]
		[SerializeField]
		private List<RewardData> _winRewards;

		[SerializeField]
		private List<RewardData> _loseRewards;

		[SerializeField]
		private List<RewardData> _drawRewards;

		[Header("Enemy Stats")]
		[SerializeField]
		private float _enemyHpMultiplier;

		[SerializeField]
		private float _enemyDamageMultiplier;

		[SerializeField]
		private int _enemyCastleHpMin;

		[SerializeField]
		private int _enemyCastleHpMax;

		[Header("Enemy Strategies")]
		[SerializeField]
		private List<ArenaEnemyStrategyData> _strategies;

		[Header("Chests")]
		[SerializeField]
		private List<ArenaChestData> _chests;

		public int RequiredRating => 0;

		public string Name => null;

		public Sprite Icon => null;

		public int WinRating => 0;

		public int LoseRating => 0;

		public List<Reward> WinRewards => null;

		public List<Reward> LoseRewards => null;

		public List<Reward> DrawRewards => null;

		public List<ArenaEnemyStrategyData> Strategies => null;

		public List<ArenaChestData> Chests => null;

		public float EnemyHpMultiplier => 0f;

		public float EnemyDamageMultiplier => 0f;

		public int EnemyCastleHpMin => 0;

		public int EnemyCastleHpMax => 0;
	}
}
