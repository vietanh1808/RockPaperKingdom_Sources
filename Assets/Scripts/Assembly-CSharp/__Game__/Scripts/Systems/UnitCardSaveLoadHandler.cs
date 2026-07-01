using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UnitCardSaveLoadHandler : DirtySaveLoadHandler<BaseCollectibleSystem<UnitCardItem, UnitCardItemData>>
	{
		private readonly UnitCardSystem _unitCardSystem;

		private readonly UnitCardConfig _unitCardConfig;

		public UnitCardSaveLoadHandler(UnitCardSystem unitCardSystem, UnitCardConfig unitCardConfig)
			: base((BaseCollectibleSystem<UnitCardItem, UnitCardItemData>)default(_00210))
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
