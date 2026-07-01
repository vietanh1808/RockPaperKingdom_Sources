using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class GameplayUpgradeSelection
	{
		[SerializeField]
		private BaseGameplayUpgrade _upgrade;

		[SerializeField]
		private bool _isBestPick;

		public BaseGameplayUpgrade Upgrade => null;

		public bool IsBestPick => false;

		public GameplayUpgradeSelection(BaseGameplayUpgrade upgrade, bool isBestPick)
		{
		}

		public GameplayUpgradeSelection(BaseGameplayUpgrade upgrade)
		{
		}
	}
}
