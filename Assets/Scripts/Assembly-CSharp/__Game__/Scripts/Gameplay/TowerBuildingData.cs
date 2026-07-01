using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_Tower_", menuName = "TapHub/Buildings/Building Data/Tower")]
	public class TowerBuildingData : BaseBuildingData
	{
		[SerializeField]
		private TowerBuilding _prefab;

		[SerializeField]
		private TowerData _towerData;

		[SerializeField]
		private UniqueBonusHolder _uniqueBonus;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public TowerBuilding TypedPrefab => null;

		public TowerData TowerData => null;

		public AbilityData MainAbility => null;

		public override UniqueBonusHolder UniqueBonus => null;

		private void OnEnable()
		{
		}
	}
}
