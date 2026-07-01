using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.MysteryCardShop
{
	[CreateAssetMenu(fileName = "Config_MysteryCardShop", menuName = "TapHub/Configs/Mystery Card Shop Config")]
	public class MysteryCardShopConfig : ScriptableObject
	{
		[SerializeField]
		private List<AddBuildingUpgrade> _firstTimeCards;

		[SerializeField]
		private List<AddBuildingUpgrade> _preferredCards;

		[SerializeField]
		private int _preferredPoolFallbackThreshold;

		public IReadOnlyList<AddBuildingUpgrade> FirstTimeCards => null;

		public IReadOnlyList<AddBuildingUpgrade> PreferredCards => null;

		public int PreferredPoolFallbackThreshold => 0;
	}
}
