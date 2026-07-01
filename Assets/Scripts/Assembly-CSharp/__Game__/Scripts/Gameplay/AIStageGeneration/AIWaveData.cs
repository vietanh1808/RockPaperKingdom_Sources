using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[Serializable]
	public class AIWaveData
	{
		public int waveIndex;

		public List<AIGridCellData> cells;
	}
}
