using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class BuildingSaveData
	{
		public int PositionX;

		public int PositionY;

		public string BuildingDataGuid;

		public int LevelIndex;

		public float CurrentHP;

		public Dictionary<int, float> BaseStats;

		public Dictionary<int, float> StatMultipliers;

		public Dictionary<int, float> StatAdditive;
	}
}
