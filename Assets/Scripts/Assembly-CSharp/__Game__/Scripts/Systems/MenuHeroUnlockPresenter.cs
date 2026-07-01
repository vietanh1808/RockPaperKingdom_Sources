using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class MenuHeroUnlockPresenter : BaseMenuCollectibleUnlockPresenter<HeroItem, HeroItemData>
	{
		private readonly UIMenuSceneNavigation _uiMenuSceneNavigation;

		public MenuHeroUnlockPresenter(UIMenuSceneNavigation uiMenuSceneNavigation, HeroSystem collectibleSystem)
			: base((BaseCollectibleSystem<HeroItem, HeroItemData>)null)
		{
		}

		protected override void ShowUnlockingItem(BaseCollectibleItemData collectibleItemData)
		{
		}
	}
}
