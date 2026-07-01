using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_AddBuilding", menuName = "TapHub/Gameplay Upgrades/Buildings/Add Building Upgrade")]
	public class AddBuildingUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private BaseBuildingData _baseBuildingData;

		public BaseBuildingData BaseBuildingData => null;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}
	}
}
