using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_Reward", menuName = "TapHub/Ability/Upgrades/Reward Upgrade")]
	public class RewardUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private RewardData _reward;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}
	}
}
