using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class StageChestItem
	{
		private StageChestState _chestState;

		public int StageIndex { get; }

		public StageChestData StageChestData { get; }

		public StageChestType ChestType { get; }

		public string ShortMessage { get; }

		public string LongMessage { get; }

		public StageChestState ChestState
		{
			get
			{
				return default(StageChestState);
			}
			set
			{
			}
		}

		public event Action OnRewardStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public StageChestItem(int stageIndex, StageChestData stageChestData)
		{
		}
	}
}
