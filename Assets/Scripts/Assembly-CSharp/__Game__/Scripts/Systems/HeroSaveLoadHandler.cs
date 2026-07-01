using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class HeroSaveLoadHandler : DirtySaveLoadHandler<BaseCollectibleSystem<HeroItem, HeroItemData>>
	{
		private readonly HeroSystem _heroSystem;

		private readonly HeroConfig _heroConfig;

		public HeroSaveLoadHandler(HeroSystem heroSystem, HeroConfig heroConfig)
			: base((BaseCollectibleSystem<HeroItem, HeroItemData>)default(_00210))
		{
		}

		protected override void LoadDirty()
		{
		}

		protected override void SaveDirty()
		{
		}

		public override string GetDataPath()
		{
			return null;
		}
	}
}
