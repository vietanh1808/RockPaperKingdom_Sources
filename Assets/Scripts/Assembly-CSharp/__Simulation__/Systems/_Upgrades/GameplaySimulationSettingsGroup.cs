using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	[Serializable]
	public class GameplaySimulationSettingsGroup
	{
		[SerializeField]
		private List<GameplaySimulationSettings> _strategies;

		public List<GameplaySimulationSettings> Strategies => null;
	}
}
