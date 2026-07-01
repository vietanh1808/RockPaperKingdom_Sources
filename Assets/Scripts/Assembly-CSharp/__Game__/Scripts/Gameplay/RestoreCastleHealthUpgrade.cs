using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_RestoreCastleHealth", menuName = "TapHub/Gameplay Upgrades/Buildings/Restore Castle Health Upgrade")]
	public class RestoreCastleHealthUpgrade : BaseGameplayUpgrade
	{
		public override bool CanBeUsed(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
			return false;
		}

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}
	}
}
