namespace __Game__.Scripts.Systems.MetaQuest
{
	public class PatrolRewardCollectionMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		public override int CurrentValue => 0;

		public PatrolRewardCollectionMetaQuestProcessor(PatrolRewardsSystem patrolRewardsSystem)
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

		private void OnRewardsClaimed()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
