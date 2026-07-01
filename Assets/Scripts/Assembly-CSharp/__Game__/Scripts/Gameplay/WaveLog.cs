using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class WaveLog
	{
		public Dictionary<PowerLogType, float> ValueByType;

		public List<BaseGameplayUpgrade> AppliedUpgrades;
	}
}
