using System;
using System.Collections.Generic;
using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	[Serializable]
	public class StrategyLog
	{
		public Dictionary<int, StageLog> StageByIndex { get; set; }
	}
}
