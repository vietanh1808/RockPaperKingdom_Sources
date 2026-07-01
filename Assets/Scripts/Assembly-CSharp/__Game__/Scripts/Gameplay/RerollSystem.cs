using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class RerollSystem
	{
		private const int SESSION_RV_REROLLS = 3;

		private const int INITIAL_FREE_REROLLS = 1;

		private const int INITIAL_RV_REROLLS_WITH_FREE = 2;

		private readonly RerollConfig _config;

		private readonly GameplayInventorySystem _inventorySystem;

		private readonly InventorySystem _metaInventorySystem;

		private readonly RerollRuntimeData _runtimeData;

		public bool HasFreeRerolls => false;

		public bool HasRvRerolls => false;

		public int FreeRerollsRemaining => 0;

		public int RvRerollsRemaining => 0;

		public int RerollsRemaining => 0;

		public bool HasRerollsAvailable => false;

		public RerollSystem(RerollConfig config, GameplayInventorySystem inventorySystem, InventorySystem metaInventorySystem, RerollRuntimeData runtimeData)
		{
		}

		public void Initialize()
		{
		}

		public void UseFreeReroll()
		{
		}

		public void UseRvReroll()
		{
		}

		private int GetFreeRerollsPerkAmount()
		{
			return 0;
		}
	}
}
