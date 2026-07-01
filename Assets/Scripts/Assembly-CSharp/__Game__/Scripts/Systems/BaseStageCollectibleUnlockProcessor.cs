using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseStageCollectibleUnlockProcessor<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly StageSystem _stageSystem;

		private readonly BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		private readonly Dictionary<int, List<TItem>> _itemPerStage;

		private int _previousStageIndex;

		protected BaseStageCollectibleUnlockProcessor(StageSystem stageSystem, BaseCollectibleSystem<TItem, TItemData> collectibleSystem)
		{
		}

		private void OnCollectibleInitialized()
		{
		}

		private void OnLastAvailableStageIndexChanged()
		{
		}

		private void AddItemPerStage(int stage, TItem item)
		{
		}

		private void AddPendingItemByStage(int stage)
		{
		}
	}
}
