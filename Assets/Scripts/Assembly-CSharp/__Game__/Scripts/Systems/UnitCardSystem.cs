using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class UnitCardSystem : BaseCollectibleSystem<UnitCardItem, UnitCardItemData>
	{
		private readonly HeroSystem _heroSystem;

		protected override string UpgradeTransactionName => null;

		public UnitCardSystem(UnitCardConfig collectibleConfig, InventorySystem inventorySystem, HeroSystem heroSystem, LionAnalyticsEvents lionAnalyticsEvents)
			: base((BaseCollectibleConfig<UnitCardItemData>)null, (InventorySystem)null, (LionAnalyticsEvents)null)
		{
		}

		public override void Initialize()
		{
		}

		public override void UnlockItem(string guid)
		{
		}

		public UnitCardItem GetItemByUpgrade(AddBuildingUpgrade upgrade)
		{
			return null;
		}

		public void ClearIsNewGameplay(UnitCardItem item)
		{
		}

		private void SyncUnlockedHeroCards()
		{
		}

		private void OnHeroUnlocked(HeroItem heroItem)
		{
		}

		private void LinkHeroesToUnitCards()
		{
		}
	}
}
