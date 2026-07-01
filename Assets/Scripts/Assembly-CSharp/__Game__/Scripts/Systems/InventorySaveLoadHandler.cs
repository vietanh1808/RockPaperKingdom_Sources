using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class InventorySaveLoadHandler : DirtySaveLoadHandler<InventorySystem>
	{
		private readonly InventoryCollection _inventoryCollection;

		private readonly InventorySystem _inventorySystem;

		public InventorySaveLoadHandler(InventorySystem inventorySystem, InventoryCollection inventoryCollection)
			: base((InventorySystem)default(_00210))
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
