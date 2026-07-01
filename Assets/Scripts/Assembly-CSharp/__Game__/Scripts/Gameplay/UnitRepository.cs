using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitRepository
	{
		private readonly Dictionary<UnitData, List<BaseUnit>> _unitsByData;

		public List<BaseUnit> Units { get; }

		public event Action<BaseUnit> OnUnitAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<BaseUnit> OnUnitRemoved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddUnit(BaseUnit unit)
		{
		}

		public void RemoveUnit(BaseUnit unit)
		{
		}

		public bool HasUnitsInRange(Vector3 position, float range)
		{
			return false;
		}

		public bool HasPriorityUnits(List<UnitData> priorityOrder)
		{
			return false;
		}

		public BaseUnit GetFirstPriorityUnitInRange(Vector3 position, float range, List<UnitData> priorityOrder)
		{
			return null;
		}

		public BaseUnit GetFirstUnitInRange(Vector3 position, float range)
		{
			return null;
		}

		public BaseUnit GetFirstNonPassivePriorityUnitInRange(Vector3 position, float range, List<UnitData> priorityOrder)
		{
			return null;
		}

		public BaseUnit GetFirstNonPassiveUnitInRange(Vector3 position, float range)
		{
			return null;
		}

		public List<BaseUnit> GetListUnitsInRange(Vector3 position, float range, int amount)
		{
			return null;
		}

		public BaseUnit GetRandomUnitInRange(Vector3 position, float range)
		{
			return null;
		}

		public BaseUnit GetRandomUnitInRange(Vector3 position, float range, BaseUnit excludeUnit)
		{
			return null;
		}

		public List<BaseUnit> GetUnitsChain(float range, int count, Vector3 position, BaseUnit enemyUnitIgnore = null)
		{
			return null;
		}

		public BaseUnit GetFurthestInLineUnit(Vector3 position)
		{
			return null;
		}

		public BaseUnit GetClosestUnit(Vector3 position, float range, List<BaseUnit> enemiesIgnore = null)
		{
			return null;
		}

		private void RegisterUnitByData(BaseUnit unit)
		{
		}

		private void UnregisterUnitByData(BaseUnit unit)
		{
		}

		private BaseUnit GetClosestUnitFromList(List<BaseUnit> units, float range, Vector3 position)
		{
			return null;
		}

		private BaseUnit GetClosestNonPassiveUnitFromList(List<BaseUnit> units, float range, Vector3 position)
		{
			return null;
		}
	}
}
