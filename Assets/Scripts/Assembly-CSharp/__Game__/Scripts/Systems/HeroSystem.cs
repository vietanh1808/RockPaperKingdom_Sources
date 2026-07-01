using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class HeroSystem : BaseCollectibleSystem<HeroItem, HeroItemData>
	{
		public List<HeroItem> ActiveHeroes { get; }

		public HeroItem SelectedHero { get; private set; }

		public int SelectedSlot { get; private set; }

		public bool IsSelectingHero { get; private set; }

		protected override string UpgradeTransactionName => null;

		public event Action OnActiveHeroesChanged
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

		public event Action OnSelectingSlot
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

		public event Action OnSelectingHero
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

		public event Action OnSelectingCanceled
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

		public HeroSystem(HeroConfig collectibleConfig, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
			: base((BaseCollectibleConfig<HeroItemData>)null, (InventorySystem)null, (LionAnalyticsEvents)null)
		{
		}

		public override void Initialize()
		{
		}

		public void OverrideActiveHeroes(List<HeroItem> overrideHeroes)
		{
		}

		public void SelectSlotForHero(HeroItem heroItem)
		{
		}

		public void SelectHeroForSlot(int slotIndex)
		{
		}

		public void ActivateSelectedHero(HeroItem selectedHero, int slotIndex)
		{
		}

		public void CancelSelecting()
		{
		}

		public override List<HeroItem> GetActiveItems()
		{
			return null;
		}

		public HeroItem GetItemBySlot(int slotIndex)
		{
			return null;
		}

		private void ActivateHeroBySlot(int slotIndex, HeroItem collectibleItem)
		{
		}

		private void SubscribeToActiveHero(HeroItem heroItem)
		{
		}

		private void UnsubscribeFromActiveHero(HeroItem heroItem)
		{
		}

		private void OnHeroLevelChanged(BaseCollectibleItem<HeroItemData> heroItem)
		{
		}
	}
}
