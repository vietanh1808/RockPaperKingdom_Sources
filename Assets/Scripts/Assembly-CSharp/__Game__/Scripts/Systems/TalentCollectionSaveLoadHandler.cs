using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class TalentCollectionSaveLoadHandler : DirtySaveLoadHandler<TalentCollectionSystem>
	{
		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly TalentCollectionConfig _talentCollectionConfig;

		public TalentCollectionSaveLoadHandler(TalentCollectionSystem talentCollectionSystem, TalentCollectionConfig talentCollectionConfig)
			: base((TalentCollectionSystem)default(_00210))
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
