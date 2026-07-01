namespace __Game__.Scripts.Systems
{
	public class HeroNewAlertSystem : BaseCollectibleNewAlertSystem<HeroItem, HeroItemData>
	{
		public HeroNewAlertSystem(HeroSystem heroSystem)
			: base((BaseCollectibleSystem<HeroItem, HeroItemData>)null)
		{
		}
	}
}
