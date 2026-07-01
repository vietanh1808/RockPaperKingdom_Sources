using System;
using System.Collections.Generic;

namespace __BattleSimulation__.Scripts
{
	[Serializable]
	public class BattleSimulationPrefsData
	{
		public Dictionary<string, int> AttackerUnitsAmount;

		public Dictionary<string, int> DefenderUnitsAmount;

		public Dictionary<string, UnitBattleSimulationStats> UnitStats;

		public float TimeScale;
	}
}
