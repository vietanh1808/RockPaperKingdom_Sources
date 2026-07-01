using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class InventoryItem
	{
		private int _amount;

		public InventoryItemData InventoryItemData { get; }

		public int Amount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<InventoryItem> OnAmountChanged
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

		public InventoryItem(InventoryItemData data, int amount)
		{
		}
	}
}
