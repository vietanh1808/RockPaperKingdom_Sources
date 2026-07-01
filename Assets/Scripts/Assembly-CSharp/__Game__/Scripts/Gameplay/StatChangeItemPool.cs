using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class StatChangeItemPool
	{
		private const int INITIAL_POOL_SIZE = 5;

		private readonly MonoObjectPool<UIBuildingStatChangeItem> _pool;

		public StatChangeItemPool(UIBuildingStatChangeItem prefab)
		{
		}

		public UIBuildingStatChangeItem Get(Vector3 position)
		{
			return null;
		}

		public void Release(UIBuildingStatChangeItem item)
		{
		}

		private static UIBuildingStatChangeItem CreateItem(UIBuildingStatChangeItem prefab)
		{
			return null;
		}
	}
}
