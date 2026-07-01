using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class EquipmentSaveLoadHandler : DirtySaveLoadHandler<EquipmentSystem>
	{
		private readonly EquipmentSystem _equipmentSystem;

		private readonly EquipmentConfig _equipmentConfig;

		public EquipmentSaveLoadHandler(EquipmentSystem equipmentSystem, EquipmentConfig equipmentConfig)
			: base((EquipmentSystem)default(_00210))
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
