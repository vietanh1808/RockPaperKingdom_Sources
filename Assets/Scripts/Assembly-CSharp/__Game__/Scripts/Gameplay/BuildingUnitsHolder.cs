using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingUnitsHolder
	{
		private readonly BuildingUnitSpawner _unitSpawner;

		private readonly List<BaseUnit> _units;

		private bool HasUnits => false;

		public IReadOnlyList<BaseUnit> Units => null;

		public BuildingUnitsHolder(BuildingUnitSpawner unitSpawner)
		{
		}

		public void SpawnUnits(BuildingRuntime buildingRuntime, Vector3 buildingWorldPosition)
		{
		}

		public void DespawnUnits()
		{
		}
	}
}
