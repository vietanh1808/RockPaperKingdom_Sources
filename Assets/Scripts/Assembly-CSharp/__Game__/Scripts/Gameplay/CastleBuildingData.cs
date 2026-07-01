using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_Castle", menuName = "TapHub/Buildings/Building Data/Castle")]
	public class CastleBuildingData : BaseBuildingData
	{
		[SerializeField]
		private Castle _prefab;

		private static readonly Dictionary<UnitStatType, float> EmptyStats;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public Castle TypedPrefab => null;
	}
}
