using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class UnitPoolManager
	{
		private readonly Dictionary<UnitData, MonoObjectPool<BaseUnit>> _unitPools;

		private readonly UnitFactory _unitFactory;

		public UnitPoolManager(UnitFactory unitFactory)
		{
		}

		public BaseUnit Get(UnitData unitData, Vector3 position)
		{
			return null;
		}

		public void Return(BaseUnit unit)
		{
		}

		private MonoObjectPool<BaseUnit> GetOrCreatePool(UnitData unitData)
		{
			return null;
		}

		private void CreatePool(UnitData unitData, int amount)
		{
		}

		private BaseUnit FactoryMethod(UnitData unitData)
		{
			return null;
		}
	}
}
