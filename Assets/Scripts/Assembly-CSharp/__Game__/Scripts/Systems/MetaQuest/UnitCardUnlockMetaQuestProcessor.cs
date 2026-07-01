namespace __Game__.Scripts.Systems.MetaQuest
{
	public class UnitCardUnlockMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly UnitCardSystem _unitCardSystem;

		private UnitCardUnlockMetaQuestData _unitCardUnlockMetaQuestData;

		public override int CurrentValue => 0;

		public UnitCardUnlockMetaQuestProcessor(UnitCardSystem unitCardSystem)
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

		private void OnCollectibleItemUnlocked(UnitCardItem unitCardItem)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
