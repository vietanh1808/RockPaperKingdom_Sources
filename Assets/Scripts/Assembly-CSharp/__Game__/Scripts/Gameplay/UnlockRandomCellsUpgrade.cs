using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_UnlockRandomCells", menuName = "TapHub/Gameplay Upgrades/Buildings/Unlock Random Cells Upgrade")]
	public class UnlockRandomCellsUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private int _cellsAmount;

		public override bool CanBeUsed(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
			return false;
		}

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		private List<Vector2Int> GetLockedPositions(BuildingSlotGrid slotGrid)
		{
			return null;
		}
	}
}
