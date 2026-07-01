using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class SharedStatSaveData
	{
		public string DataGuid;

		public Dictionary<int, float> BaseStats;

		public Dictionary<int, float> StatMultipliers;

		public Dictionary<int, float> StatAdditive;
	}
}
