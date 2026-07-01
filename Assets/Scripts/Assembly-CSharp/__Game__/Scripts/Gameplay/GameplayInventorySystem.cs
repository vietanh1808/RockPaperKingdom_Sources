using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayInventorySystem
	{
		private readonly Dictionary<string, InventoryItem> _items;

		public event Action<InventoryItem> OnItemAmountChanged
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

		public GameplayInventorySystem(GameplayInventoryCollection collection)
		{
		}

		public InventoryItem GetItem(string guid)
		{
			return null;
		}

		public bool HasEnoughItems(string guid, int amount)
		{
			return false;
		}

		public void AddAmount(string guid, int amount)
		{
		}

		public void RemoveAmount(string guid, int amount)
		{
		}

		public void SetAmount(string guid, int amount)
		{
		}

		public Dictionary<string, int> GetAllItemAmounts()
		{
			return null;
		}

		public void RestoreProgress(Dictionary<string, int> itemAmounts)
		{
		}

		private void HandleAmountChanged(InventoryItem item)
		{
		}
	}
}
