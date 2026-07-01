using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_UnitSpawn_", menuName = "TapHub/Buildings/Building Data/Unit Spawn")]
	public class UnitSpawnBuildingData : BaseBuildingData
	{
		[SerializeField]
		private UnitSpawnBuilding _prefab;

		[SerializeField]
		private UnitData _spawnUnit;

		[SerializeField]
		private UniqueBonusHolder _uniqueBonus;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public UnitSpawnBuilding TypedPrefab => null;

		public UnitData SpawnUnit => null;

		public override UniqueBonusHolder UniqueBonus => null;

		private void OnEnable()
		{
		}
	}
}
