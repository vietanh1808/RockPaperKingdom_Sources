using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_Mirror_", menuName = "TapHub/Buildings/Building Data/Mirror Building")]
	public class MirrorBuildingData : BaseBuildingData
	{
		[SerializeField]
		private MirrorBuilding _prefab;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public MirrorBuilding TypedPrefab => null;

		public override bool CanAffectBuilding(BaseBuilding building)
		{
			return false;
		}
	}
}
