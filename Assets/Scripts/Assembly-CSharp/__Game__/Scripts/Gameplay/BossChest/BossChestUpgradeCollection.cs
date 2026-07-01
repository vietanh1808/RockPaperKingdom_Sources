using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.BossChest
{
	[CreateAssetMenu(fileName = "Collection_BossChestUpgrade", menuName = "TapHub/BossChest/BossChestUpgradeCollection")]
	public class BossChestUpgradeCollection : SerializedScriptableObject
	{
		[SerializeField]
		private List<BaseGameplayUpgrade> _upgrades;

		public List<BaseGameplayUpgrade> Upgrades => null;
	}
}
