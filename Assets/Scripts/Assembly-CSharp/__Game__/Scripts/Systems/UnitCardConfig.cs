using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_UnitCard", menuName = "TapHub/Collectible/UnitCard/UnitCard Config")]
	public class UnitCardConfig : BaseCollectibleConfig<UnitCardItemData>
	{
		[Header("Unlock Reward")]
		[SerializeField]
		private Reward _unlockReward;

		public Reward UnlockReward => null;
	}
}
