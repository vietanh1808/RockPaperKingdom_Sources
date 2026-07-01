using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class StageBossChestUpgradeRound
	{
		[SerializeField]
		private List<BaseGameplayUpgrade> _upgrades;

		public List<BaseGameplayUpgrade> Upgrades => null;
	}
}
