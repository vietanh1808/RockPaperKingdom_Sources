using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_AddRandomBuildingCards", menuName = "TapHub/Gameplay Upgrades/Buildings/Add Random Building Cards Upgrade")]
	public class AddRandomBuildingCardsUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private int _cardsAmount;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		private List<BaseGameplayUpgrade> GetAvailableBuildingUpgrades(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
			return null;
		}
	}
}
