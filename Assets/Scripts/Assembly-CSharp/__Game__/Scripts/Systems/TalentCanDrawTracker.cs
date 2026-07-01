using System;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class TalentCanDrawTracker : IInitializable, IDisposable
	{
		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly TalentCollectionConfig _talentCollectionConfig;

		private readonly InventorySystem _inventorySystem;

		private InventoryItem _primaryInventoryItem;

		private InventoryItem _secondaryInventoryItem;

		public bool CanDrawTalent { get; private set; }

		public event Action OnCanDrawStatusChanged
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

		public TalentCanDrawTracker(TalentCollectionSystem talentCollectionSystem, TalentCollectionConfig talentCollectionConfig, InventorySystem inventorySystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnTalentDrawCompleted(TalentRuntime talentRuntime)
		{
		}

		private void OnResourcesAmountChanged(InventoryItem inventoryItem)
		{
		}

		private void UpdateCanDrawStatus()
		{
		}
	}
}
