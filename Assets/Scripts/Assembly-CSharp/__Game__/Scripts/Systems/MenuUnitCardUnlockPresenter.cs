using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class MenuUnitCardUnlockPresenter : BaseMenuCollectibleUnlockPresenter<UnitCardItem, UnitCardItemData>
	{
		private readonly UIMenuSceneNavigation _uiMenuSceneNavigation;

		public MenuUnitCardUnlockPresenter(UIMenuSceneNavigation uiMenuSceneNavigation, UnitCardSystem collectibleSystem)
			: base((BaseCollectibleSystem<UnitCardItem, UnitCardItemData>)null)
		{
		}

		protected override void ShowUnlockingItem(BaseCollectibleItemData collectibleItemData)
		{
		}
	}
}
