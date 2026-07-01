using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_DestroyExpand_", menuName = "TapHub/Buildings/Building Data/Destroy Expand Building")]
	public class DestroyExpandBuildingData : BaseBuildingData
	{
		[SerializeField]
		private SoundData _applySfx;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public SoundData ApplySfx => null;
	}
}
