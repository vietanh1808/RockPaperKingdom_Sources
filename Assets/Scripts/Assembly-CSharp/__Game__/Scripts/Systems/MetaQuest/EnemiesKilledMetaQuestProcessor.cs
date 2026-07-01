using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class EnemiesKilledMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly EnemyKillTracker _enemyKillTracker;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private EnemiesKilledMetaQuestData _enemiesKilledData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public EnemiesKilledMetaQuestProcessor(EnemyKillTracker enemyKillTracker, DailyStreakQuestSystem dailyStreakQuestSystem)
		{
		}

		public override void Initialize(BaseMetaQuestData data)
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void OnEnemyKilled()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
