using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaChestItem
	{
		private StageChestState _chestState;

		public int TierIndex { get; }

		public ArenaChestData ChestData { get; }

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

		public event Action OnStateChanged
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

		public ArenaChestItem(int tierIndex, ArenaChestData chestData)
		{
		}
	}
}
