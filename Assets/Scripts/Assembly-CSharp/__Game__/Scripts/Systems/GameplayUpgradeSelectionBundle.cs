using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class GameplayUpgradeSelectionBundle
	{
		[SerializeField]
		private List<GameplayUpgradeSelection> _upgrades;

		public List<GameplayUpgradeSelection> Upgrades => null;
	}
}
