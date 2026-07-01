namespace __Game__.Scripts.Systems.MetaQuest
{
	public class PlayerUpgradeMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly PlayerUpgradesSystem _playerUpgradesSystem;

		private PlayerUpgradeMetaQuestData _playerUpgradeMetaQuestData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public PlayerUpgradeMetaQuestProcessor(PlayerUpgradesSystem playerUpgradesSystem)
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

		private void OnUpgradeIndexChanged()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
